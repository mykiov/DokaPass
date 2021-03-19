using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DokaPass
{
    public static class Crypter
    {
        internal static string Encrypt(string name, string pin, string key)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            return null;
        }
    }
}
