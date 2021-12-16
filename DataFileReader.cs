using Lab1b_CleanCode_ReadFromFile;
using System;
using System.IO;
using System.Text;

namespace ReadFromFile
{
	public class DataFileReader: IGetStringReader
	{
		private const string filePath = @"C:\\Users\\admin\\source\\repos\\Lab1b_CleanCode_ReadFromFile\\TextFolder\\PoeEdgarAllen.txt";
		public string ReadMyDataFile(string textFile)
		{
			//bool readWasSuccessful = false;
			try
			{
				if (filePath == null) throw new ArgumentException("File was null");
				if (String.IsNullOrEmpty(filePath)) throw new ArgumentException("First line was empty");
				StreamReader streamReader = new StreamReader(filePath);
				while (streamReader != null && streamReader.Peek() > 0)
                {
					return streamReader.ReadLine();
					//Console.WriteLine(ReverseTxtFile.ReverseMyText(streamReader.ReadLine()));
					//readWasSuccessful = true;
                }
			}
			catch (ArgumentException e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
			return filePath;
		}

        //public static string ReverseMyText(string textToReverse)
        //{
        //    if (textToReverse == null)
        //        throw new ArgumentNullException();

        //    StringBuilder reversedText = new StringBuilder();
        //    for (int i = textToReverse.Length - 1; i >= 0; i--)
        //    {
        //        reversedText.Append(textToReverse[i]);
        //    }
        //    return reversedText.ToString();
        //}
    }
}

