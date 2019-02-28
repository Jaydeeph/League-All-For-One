using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace League_All_in_One
{
    //Aquired the encryption from https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.rijndael?view=netframework-4.7.2
    //Modified it to suit my needs.
    static class Encryption
    {
        private static Rijndael myRijndael = Rijndael.Create();

        public static string ConvertRijndaelIVToBase64()
        {
            return Convert.ToBase64String(myRijndael.IV);
        }

        public static string ConvertRijndaelKeyToBase64()
        {
            return Convert.ToBase64String(myRijndael.Key);
        }

        public static byte[] ConvertRijndaelIVToByteFromBase64(string rijndaelIV)
        {
            return Convert.FromBase64String(rijndaelIV);
        }

        public static byte[] ConvertRijndaelKeyToByteFromBase64(string rijndaelKey)
        {
            return Convert.FromBase64String(rijndaelKey);
        }

        public static string EncryptNewPassword(string plainPassword)
        {
            return EncryptStringUsingRijndael(plainPassword, myRijndael.Key, myRijndael.IV);
        }

        public static string EncryptCurrentPassword(string plainPassword, byte[] rijndaelKey, byte[] rijndaelIV)
        {
            return EncryptStringUsingRijndael(plainPassword, myRijndael.Key, myRijndael.IV);
        }

        public static string Decrypt(string decryptPassword, byte[] rijndaelKey, byte[] rijndaelIV)
        {
            return DecryptStringUsingRijndael(decryptPassword, myRijndael.Key, myRijndael.IV);
        }

        private static string EncryptStringUsingRijndael(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            // Create an Rijndael object
            // with the specified key and IV.
            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            // Return the encrypted bytes from the memory stream after converting it to Base64.
            return Convert.ToBase64String(encrypted);
        }

        private static string DecryptStringUsingRijndael(string cipherTextString, byte[] Key, byte[] IV)
        {
            //Check argument.
            if (!IsBase64String(cipherTextString))
                throw new Exception("The cipherText input parameter is not base64 encoded");

            //Convert from Base64 back to array of bytes.
            byte[] cipherText = Convert.FromBase64String(cipherTextString);

            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Rijndael object
            // with the specified key and IV.
            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }
            // Return the decrypted bytes from the memory stream.
            return plaintext;
        }

        public static bool IsBase64String(string base64String)
        {
            base64String = base64String.Trim();
            return (base64String.Length % 4 == 0) && Regex.IsMatch(base64String, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);

        }

        public static string ConvertToBase64(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string ConvertFromBase64(string encryptedText)
        {
            var base64EncodedBytes = Convert.FromBase64String(encryptedText);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
