using SixLabors.ImageSharp.Formats.Png;
using System.Security.Cryptography;
using System.Text;

namespace API_AppCobranca.Suporte
{
    public class TratamentoImg
    {
        public MemoryStream DecryptFile(string sInputFilename)
        {
            string sKey = "14785236";
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider
            {
                Key = ASCIIEncoding.ASCII.GetBytes(sKey),
                IV = ASCIIEncoding.ASCII.GetBytes(sKey)
            };

            MemoryStream sOutputFilename = new MemoryStream();

            using (FileStream fsread = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read))
            {
                ICryptoTransform desdecrypt = DES.CreateDecryptor();
                using (CryptoStream cryptostreamDecr = new CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read))
                {
                    byte[] buffer = new byte[1024];
                    int length = cryptostreamDecr.Read(buffer, 0, buffer.Length);

                    while (length > 0)
                    {
                        sOutputFilename.Write(buffer, 0, length);
                        length = cryptostreamDecr.Read(buffer, 0, buffer.Length);
                    }
                }
            }

            sOutputFilename.Position = 0;
            return sOutputFilename;
        }
    }
}
