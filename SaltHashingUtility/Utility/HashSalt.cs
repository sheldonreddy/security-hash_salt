using SaltHashingUtility.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SaltHashingUtility.Utility
{
    public class HashSalt
    {
          public static HashWithSaltResult HashPassword(string password)
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            HashWithSaltResult hashResultSha256 = new HashWithSaltResult();

            try
            {
                hashResultSha256 = pwHasher.HashWithSalt(password, 64, SHA256.Create());
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }

            return hashResultSha256;
        }
    }
}
