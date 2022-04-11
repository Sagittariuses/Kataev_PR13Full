using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RMP_PR11.LocalClasses
{
    public class Hashing
    {
        public static string PasswordHashing(string password)
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
