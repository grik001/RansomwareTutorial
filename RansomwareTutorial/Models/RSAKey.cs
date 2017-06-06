using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomwareTutorial.Models
{
    public class RSAKey
    {
        public string PublicKey { get; private set; }
        public string PrivateKey { get; private set; }

        public RSAKey(string privateKey, string publicKey)
        {
            this.PublicKey = publicKey;
            this.PrivateKey = privateKey;
        }
    }
}
