using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class MD5Hash
    {
        public string MD5(string tulisan)
        {
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            byte[] vs;
            UTF8Encoding encoding = new UTF8Encoding();
            vs = provider.ComputeHash(encoding.GetBytes(tulisan));
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < vs.Length; i++)
            {
                builder.Append(vs[i].ToString());
            }
            return builder.ToString();
        }
    }
}
