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
        public const string PRIVATE_KEY = "<RSAKeyValue><Modulus>0RvWnTt6BxCCc41PaqngSiapR/fAE0+Npl6sySNmKJxEpvX75TkkEoCIBxfjSwj+OGYiq3mpKpdlvPnJHIVTZem56ITsbxSpjT1OtqYE/dif/Ux7YdU0SprUu3N5q2yEwXaC25IVh1/wrWG9HQ6Lx4BxC7mZQDfdl63uZ6bWiv0=</Modulus><Exponent>AQAB</Exponent><P>8/UwQzOA/X619SL8G5Lx+iffbEXndJ9+zqWx80TVJ2OHkG0giS8m6U9+EhtVSPsLRCAMq8/nnF+YjzxRlgsI2w==</P><Q>225GR1EpJUaFdNmGgyDZTjjq/oyytpxeFj9VUE3mpKGDgiBGzIKmfMvB6Z5sgdritFy9t4qiC0Vp5uTxflr3Bw==</Q><DP>Ci9CRIvx5qNTlVhQjhYkY/0mJq8Eaqn98UKZmz5UZ8CP+EeWBCQjy7m12auqc9GHNuDfpoyXbr/O7qvl/A2Z4Q==</DP><DQ>o5zr5g1MIrEcnW38cBW0MjEad0atkp+xP+FlWYVcbnDHv+UVJTRdszuykOFBgumUlGt6QjqqbMELH9ChiFeHTQ==</DQ><InverseQ>48V+k7ibRqc59RecZcEnH+zLaBpnKq0kjsZUuvShPI7u+hpoErHFPVqx0eLg51bLqvXGjuJt1FXU/eD6RR6taA==</InverseQ><D>yw8mfG8aU6vjkgRiX2jxZfBfKITcn6P8INgFIBlhBgSh4iQy5Wh0sAbikUjQLrhf7jK4bh3peXOllzpU4n5R+X5d/ba1eBmRpyf3xpBoeBp9VJKvzJwwo5EuYaK2tnH8Mwikfah7C0khyWdr0P9SoxgTyDLRGYW5fKXAb0hJQ70=</D></RSAKeyValue>";
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

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ba.Length; i++)
            {
                sb.Append(ba[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static bool CheckKey(string key)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(512))
                {
                    rsa.FromXmlString(key);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static string GetPublicKey()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(512))
            {
                rsa.FromXmlString(PRIVATE_KEY);
                return rsa.ToXmlString(false);
            }
        }

        public static string GetRSAEncrypt(string text, string key)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(512))
            {
                rsa.FromXmlString(key);
                byte[] data = Encoding.UTF8.GetBytes(text);
                byte[] encrypted = rsa.Encrypt(data, false);
                return ByteArrayToString(encrypted);
            }
        }

        public static string GetRSADecrypt(string text, string key)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(512))
            {
                rsa.FromXmlString(PRIVATE_KEY);
                byte[] data = StringToByteArray(text);
                byte[] decrypted = rsa.Decrypt(data, false);
                return Encoding.UTF8.GetString(decrypted);
            }
        }
    }
}
