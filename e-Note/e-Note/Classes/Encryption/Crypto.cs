using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace e_Note.Classes.Encryption
{
    public class Crypto
    {
        private static byte[] _salt = Encoding.ASCII.GetBytes("ezakulcsamindennek");
        /// AES titkoítás a sharedSecret kulcsszóval
        public string EncryptStringAES(string plainText, string sharedSecret)
        {

            string cipherText = null;         // visszadobandó string
            RijndaelManaged Rijndael = null; // RijndaelManaged osztály a titkosításhoz

            try
            {
                // kulcs generálása a _salt és a sharedSecret jelszóból
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // RijndaelManaged példányosítás 
                Rijndael = new RijndaelManaged();
                Rijndael.Key = key.GetBytes(Rijndael.KeySize / 8);

                //encryptor példányosítás a stream transformhoz
                ICryptoTransform encryptor = Rijndael.CreateEncryptor(Rijndael.Key, Rijndael.IV);

                // Memorystream példányosítás
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // IV előkészítése
                    msEncrypt.Write(BitConverter.GetBytes(Rijndael.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(Rijndael.IV, 0, Rijndael.IV.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Minden adat beírása
                            swEncrypt.Write(plainText);
                        }
                    }
                    cipherText = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {
                // Rijndael kiürítése
                if (Rijndael != null)
                    Rijndael.Clear();
            }
            return cipherText;
        }

        /// AES titkoítás visszafejtése a sharedSecret kulcsszóval
        public string DecryptStringAES(string cipherText, string sharedSecret)
        {
            RijndaelManaged Rijndael = null; // RijndaelManaged osztály a visszafejtéshez

            string plaintext = null;// visszadobandó string

            try
            {
                // kulcs generálása
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // MemoryStream példányosítás               
                byte[] bytes = Convert.FromBase64String(cipherText);
                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {
                    // RijndaelManaged példányosítás
                    // kulcs és IV használata
                    Rijndael = new RijndaelManaged();
                    Rijndael.Key = key.GetBytes(Rijndael.KeySize / 8);
                    // Az IV kiolvasása a stream-ből
                    Rijndael.IV = ReadByteArray(msDecrypt);
                    // decryptor példányosítás majd használata
                    ICryptoTransform decryptor = Rijndael.CreateDecryptor(Rijndael.Key, Rijndael.IV);
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))

                            // a streamből stringbe áthelyezés
                            plaintext = srDecrypt.ReadToEnd(); //itt akad meg ha nem jó a jelszó
                    }
                }
            }
            catch (System.Security.Cryptography.CryptographicException e)
            {
                return "nope";
            }
            finally
            {
                // Rijndael kiürítése
                if (Rijndael != null)
                    Rijndael.Clear();
            }

            return plaintext;
        }

        private static byte[] ReadByteArray(Stream s)
        {
            byte[] rawLength = new byte[sizeof(int)];
            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
            {
                throw new SystemException("Nincs a streamben megfelelő byte tömb!");
            }

            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException("Probléma van a byte tömb-el!");
            }

            return buffer;
        }
    }

}

