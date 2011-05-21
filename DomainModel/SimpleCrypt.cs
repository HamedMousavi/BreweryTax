using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Entities.Abstract;


namespace DomainModel
{

    public class SimpleCrypt : ICrypt
    {

        #region ICrypt Members

        public string Encrypt(string plainText)
        {
            if (string.IsNullOrEmpty(plainText)) return string.Empty;

            byte[] dataToEncrypt = Encoding.UTF8.GetBytes(plainText);
            byte[] cipherBytes = Encrypt(dataToEncrypt);
            return Convert.ToBase64String(cipherBytes);
        }

        public string Decrypt(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText)) return string.Empty;

            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] decryptedData = Decryp(cipherBytes);
            return Encoding.UTF8.GetString(decryptedData);
        }

        #endregion


        protected byte[] Vector = new byte[] { 3, 101, 191, 253, 53, 14, 250, 195, 131, 174, 19, 52, 158, 244, 152, 39 };
        protected byte[] PublicKey = new byte[] { 53, 70, 227, 226, 89, 120, 245, 41, 175, 188, 91, 97, 138, 234, 248, 173, 168, 85, 128, 65, 119, 144, 188, 133, 187, 18, 207, 179, 186, 13, 157, 217 };


        private byte[] Encrypt(byte[] plainBytes)
        {
            RijndaelManaged aes = null;
            MemoryStream msEncrypt = null;
            CryptoStream csEncrypt = null;

            byte[] res = null;

            try
            {

                aes = new RijndaelManaged();
                aes.Key = this.PublicKey;
                aes.IV = this.Vector;

                ICryptoTransform encryptor = aes.CreateEncryptor(PublicKey, Vector);

                msEncrypt = new MemoryStream();
                csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);

                csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                csEncrypt.Close();
                csEncrypt = null;

                res = msEncrypt.ToArray();
            }
            catch (Exception ex)
            {/*
                DomainModel.ApplicationState.Instance.Controller.UpdateStatus(
                    new StatusController.Entities.StatusInfo(
                        (Int16)StatusCodes.Assemblies.Codes.DomainModel,
                        (Int16)StatusCodes.Sections.Codes.Security,
                        StatusController.Abstract.StatusTypes.Error,
                        (Int32)StatusCodes.Errors.Codes.EncryptionFailed,
                        null, ex.ToString()));*/
            }
            finally
            {
                if (csEncrypt != null) csEncrypt.Close();
                if (msEncrypt != null) msEncrypt.Close();

                // Clear the AesManaged object.
                if (aes != null) aes.Clear();
            }

            return res;
        }


        private byte[] Decryp(byte[] cipherBytes)
        {
            RijndaelManaged aes = null;
            MemoryStream msDecrypt = null;
            CryptoStream csDecrypt = null;

            byte[] res = null;

            try
            {
                aes = new RijndaelManaged();
                aes.Key = PublicKey;
                aes.IV = Vector;

                ICryptoTransform decryptor = aes.CreateDecryptor(PublicKey, Vector);

                msDecrypt = new MemoryStream(cipherBytes);
                csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);

                byte[] buffer = new byte[cipherBytes.Length];
                int read = csDecrypt.Read(buffer, 0, buffer.Length);

                res = new byte[read];
                Buffer.BlockCopy(buffer, 0, res, 0, read);
            }
            catch (Exception ex)
            {/*
                DomainModel.ApplicationState.Instance.Controller.UpdateStatus(
                    new StatusController.Entities.StatusInfo(
                        (Int16)StatusCodes.Assemblies.Codes.DomainModel,
                        (Int16)StatusCodes.Sections.Codes.Security,
                        StatusController.Abstract.StatusTypes.Error,
                        (Int32)StatusCodes.Errors.Codes.DecryptionFailed,
                        null, ex.ToString()));*/
            }
            finally
            {
                if (csDecrypt != null) csDecrypt.Close();
                if (msDecrypt != null) msDecrypt.Close();

                // Clear the AesManaged object.
                if (aes != null) aes.Clear();
            }

            return res;
        }

    }
}
