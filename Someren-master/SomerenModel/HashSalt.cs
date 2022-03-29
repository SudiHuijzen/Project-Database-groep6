using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SomerenModel
{
    public class HashSalt
    {
        public string Salt { get; set; }
        public string Hash { get; set; }
      
        public bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {
            var saltBytes = Convert.FromBase64String(storedSalt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 10000);
            return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == storedHash;
        }
    }

    public static HashSalt GenerateHashWithSalt(int size, string password)
    {/*
            RNG rng = new RNG();
            byte[] saltBytes = rng.GenerateRandomCryptographicBytes(saltLength);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new HashWithSaltResult(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes));*/
        var saltBytes = new byte[size];
        var provider = new RNGCryptoServiceProvider();
        provider.GetNonZeroBytes(saltBytes);
        var salt = Convert.ToBase64String(saltBytes);

        var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
        var hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

        HashSalt hashSalt = new HashSalt { Hash = hashPassword, Salt = salt };
        return hashSalt;

    }


}
