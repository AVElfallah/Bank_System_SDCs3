using System.Drawing;
using System.IO;

namespace Bank_System.model
{
    public static class photo
    {
        public static byte[] encryption(string photoPath)
        {
            FileStream FS = new FileStream(photoPath, FileMode.Open, FileAccess.Read);
            byte[] photoEnc = new byte[FS.Length];
            FS.Read(photoEnc, 0, photoEnc.Length);

            return photoEnc;
        }
        public static Image decryption(byte[] photoEnc)
        {
            MemoryStream ms1 = new MemoryStream(photoEnc);
            return Bitmap.FromStream(ms1);
        }
    }
}
