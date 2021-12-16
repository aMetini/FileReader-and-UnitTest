using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1b_CleanCode_ReadFromFile
{
    public class Runner
    {
        private readonly IGetStringReader _stringReader;
        private readonly IGetStringReverser _stringReverser;

        public Runner(IGetStringReader getStringReader)
        {
            _stringReader = getStringReader;
            //_stringReverser = getStringReverser;
        }

        public string Run()
        {
            //string aht = ReadTxtFile.ReadMyFile("C:\\Users\\admin\\source\\repos\\Lab1b_CleanCode_ReadFromFile\\TextFolder\\PoeEdgarAllen.txt");
            string dataFile = _stringReader.ReadMyDataFile(@"C:\\Users\\admin\\source\\repos\\Lab1b_CleanCode_ReadFromFile\\TextFolder\\PoeEdgarAllen.txt");
            //string dataTextReversed = _stringReverser.ReverseMyText(dataFile);

            // reverseing logic on string
            return new ReverseTxtFile().ReverseMyText(dataFile);
        }
    }
}
