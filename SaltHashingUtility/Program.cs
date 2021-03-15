using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using SaltHashingUtility.Log;

namespace SaltHashingUtility
{

    public class HashWithSaltResult
    {
        public string Salt { get; }
        public string Digest { get; set; }

        public byte[] SaltBytes { get; set; }

        public HashWithSaltResult()
        {

        }

        public HashWithSaltResult(string salt, string digest)
        {
            Salt = salt;
            Digest = digest;
        }

        public HashWithSaltResult(string salt, string digest, byte[] saltBytes)
        {
            Salt = salt;
            Digest = digest;
            SaltBytes = saltBytes;
        }
    }

    public class PasswordWithSaltHasher
    {

        public HashWithSaltResult HashWithSalt(string password, int saltLength, HashAlgorithm hashAlgo)
        {
            RNG rng = new RNG();
            byte[] saltBytes = rng.GenerateRandomCryptographicBytes(saltLength);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new HashWithSaltResult(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes), saltBytes);
        }

        public HashWithSaltResult HashWithSalt(byte[] passwordAsBytes, int saltLength, HashAlgorithm hashAlgo)
        {
            RNG rng = new RNG();
            byte[] saltBytes = rng.GenerateRandomCryptographicBytes(saltLength);
            //byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new HashWithSaltResult(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes));
        }

        public HashWithSaltResult HashWithSalt(string password, int saltLength, HashAlgorithm hashAlgo, byte[] saltBytes)
        {
            RNG rng = new RNG();
            //byte[] saltBytes = rng.GenerateRandomCryptographicBytes(saltLength);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new HashWithSaltResult(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes));
        }

        public HashWithSaltResult HashWithSalt(byte[] passwordAsBytes, int saltLength, HashAlgorithm hashAlgo, byte[] saltBytes)
        {
            RNG rng = new RNG();
            //byte[] saltBytes = rng.GenerateRandomCryptographicBytes(saltLength);
            //byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new HashWithSaltResult(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes));
        }
    }
    
    public class RNG
    {
        public string GenerateRandomCryptographicKey(int keyLength)
        {
            try
            {
                return Convert.ToBase64String(GenerateRandomCryptographicBytes(keyLength));
            }
            catch(Exception ex)
            {
                Logger.Exception(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }

            return "";
        }

        public byte[] GenerateRandomCryptographicBytes(int keyLength)
        {
            try
            {
                RNGCryptoServiceProvider rngCryptoServiceProvider = new RNGCryptoServiceProvider();
                byte[] randomBytes = new byte[keyLength];
                rngCryptoServiceProvider.GetBytes(randomBytes);
                return randomBytes;
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }

            return new byte[0];
        }
    }

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialise TraceLogger
            Logger.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new hashingForm());
        }
    }
}
