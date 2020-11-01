using System;
using System.IO;

namespace _5._Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            int pieceCount = 5;
            using (FileStream stream = new FileStream("../../../input.txt", FileMode.Open))
            {
                long size = stream.Length / 5;
                for (int i = 0; i < pieceCount; i++)
                {
                    using (var pieceStream = new FileStream($"../../../part-{i + 1}.txt", FileMode.Create))
                    {
                        byte[] buffer = new byte[5];
                        int count = 0;
                        while (count < size)
                        {
                            stream.Read(buffer, 0, buffer.Length);
                            pieceStream.Write(buffer, 0, buffer.Length);
                            count+=buffer.Length;
                        }
                    }

                }
            }

        }
    }
}
