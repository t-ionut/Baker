using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Baker
{
    public class SaltedHash
    {
        #region - Declarations
        public string Hash { get; private set; }
        public string Salt { get; private set; }
        #endregion

        #region - Constructor
        /// <summary>
        /// constructor
        /// </summary>
        public SaltedHash()
        {

        }

        /// <summary>
        /// constructor that generate salt and hash
        /// </summary>
        /// <param name="password"></param>
        public SaltedHash(string password)
        {
            var saltBytes = new byte[32];
            var provider = RandomNumberGenerator.Create();
            provider.GetNonZeroBytes(saltBytes);

            Salt = Convert.ToBase64String(saltBytes);
            var passwordAndSaltBytes = Concat(password, saltBytes);
            Hash = ComputeHash(passwordAndSaltBytes);
        }
        #endregion

        #region - Methods
        /// <summary>
        /// convert to byte base 64
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        static string ComputeHash(byte[] bytes)
        {
            using (var sha256 = SHA256.Create())
            {
                return Convert.ToBase64String(sha256.ComputeHash(bytes));
            }
        }

        /// <summary>
        /// concat bytes
        /// </summary>
        /// <param name="password"></param>
        /// <param name="saltBytes"></param>
        /// <returns></returns>
        private byte[] Concat(string password, byte[] saltBytes)
        {
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            return passwordBytes.Concat(saltBytes).ToArray();
        }

        /// <summary>
        /// verify password
        /// </summary>
        /// <param name="salt"></param>
        /// <param name="hash"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Verify(string salt, string hash, string password)
        {
            var saltBytes = Convert.FromBase64String(salt);
            var passwordAndSaltBytes = Concat(password, saltBytes);
            var hashAttempt = ComputeHash(passwordAndSaltBytes);
            return hash == hashAttempt;
        }
        #endregion
    }
}