using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Lab1b_CleanCode_ReadFromFile;

namespace ReadFromFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IGetStringReader dataFileReader = new DataFileReader();
            //IGetStringReverser dataReverser = new ReverseTxtFile();

            Runner runner = new Runner(dataFileReader);
            string dataFile = dataFileReader.ReadMyDataFile(@"C:\\Users\\admin\\source\\repos\\Lab1b_CleanCode_ReadFromFile\\TextFolder\\PoeEdgarAllen.txt");
            //string reversedString = dataFileReader.ReadMyDataFile();
            string reversedString = new ReverseTxtFile().ReverseMyText(dataFile);

            Console.WriteLine(reversedString);
           
        }
    }
}