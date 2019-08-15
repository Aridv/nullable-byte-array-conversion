using System;
using System.IO;
using System.Linq;

namespace NullableByteArrayConversion
{
    class NullableByteArrayConversion
    {
        static void Main(string[] args)
        {
            //byte[] to byte?[]:
            byte[] byteArray1 = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "filename.pdf");
            byte[] byteArrayBase64String = Convert.FromBase64String("base64String");

            byte?[] file1 = new byte?[byteArray1.Length];

            for (int i = 0; i < byteArray1.Length; i++)
            {
                file1[i] = byteArray1[i];
            }

            //byte?[] to byte[]:
            byte?[] file2 = new byte?[] { };
            byte[] byteArray2 = file2 != null ? file2.Select(b => b ?? default(byte)).ToArray() : File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "filename.pdf");
        }
    }
}