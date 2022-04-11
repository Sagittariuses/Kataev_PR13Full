using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibForClasses
{
    public class DataHashing
    {
        public string PasswordHashing(string password)
        {
            using (SHA256 sHA256Hash = SHA256.Create())
            {
                byte[] sourceBytePassw = Encoding.UTF8.GetBytes(password);
                byte[] HashsourceBytePassw = sHA256Hash.ComputeHash(sourceBytePassw);
                string hashPass = BitConverter.ToString(HashsourceBytePassw).Replace("-", String.Empty);
                return hashPass;
            }
        }
    }
}
