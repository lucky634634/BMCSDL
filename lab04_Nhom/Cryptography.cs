using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using Microsoft.Identity.Client.Kerberos;

namespace lab04_Nhom
{
    public class Cryptography
    {
        public static string GetSHA1Hash(string str)
        {
            if (str == null || str.Length == 0)
                return "";
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(str);
                byte[] hash = sha1.ComputeHash(bytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public static string GetMd5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static string GetAESEncrypt(string text, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            if (keyBytes.Length < 32)
            {
                int diff = 32 - keyBytes.Length;
                for (int i = 0; i < diff; i++)
                {
                    keyBytes = keyBytes.Concat(new byte[] { 0 }).ToArray();
                }
            }
            else
            {
                keyBytes = keyBytes.Take(32).ToArray();
            }
            byte[] encrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.KeySize = 256;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = keyBytes;
                byte[] iv = new byte[aes.BlockSize / 8];
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(text);
                        }
                        encrypted = ms.ToArray();
                    }
                }
            }
            return BitConverter.ToString(encrypted).Replace("-", "");
        }

        public static string GetAESDecrypt(string text, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes("21127077");
            if (keyBytes.Length < 32)
            {
                int diff = 32 - keyBytes.Length;
                for (int i = 0; i < diff; i++)
                {
                    keyBytes = keyBytes.Concat(new byte[] { 0 }).ToArray();
                }
            }
            else
            {
                keyBytes = keyBytes.Take(32).ToArray();
            }
            byte[] buffer = StringToByteArray(text);
            string decrypted = string.Empty;
            using (Aes aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.KeySize = 256;
                aes.Key = keyBytes;
                byte[] iv = new byte[aes.BlockSize / 8];
                aes.IV = iv;

                using (ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    using (MemoryStream ms = new MemoryStream(buffer))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(cs))
                            {
                                decrypted = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            return decrypted;
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
