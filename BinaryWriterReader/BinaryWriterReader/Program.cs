using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryWriterReader
    {
    class Program
        {
        static void Main(string [] args)
            {
            Console.WriteLine("____Fun With Binary Writers____\n");
            //Открыть средство двоичной записи в файл
            FileInfo f = new FileInfo("BinFile.dat");

            using (BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
                {
                //Вывести на консоль тип BaseStream
                //(System.IO.FileStream в данном случае)
                Console.WriteLine("Base stream is: {0}", bw.BaseStream);

                //Создать данные для хранения в файле
                double aDouble = 123.67;
                int aInt = 124245;
                string aString = "A B C";

                //Записать данные
                bw.Write(aDouble);
                bw.Write(aInt);
                bw.Write(aString);
                }
            
            //Считать данные из потока
            using (BinaryReader br = new BinaryReader(f.OpenRead()))
                {
                Console.WriteLine(br.ReadDouble());
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
                }
            Console.WriteLine("Done!");
            Console.ReadLine();
            }
        }
    }
