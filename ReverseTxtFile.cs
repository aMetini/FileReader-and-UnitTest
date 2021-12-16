using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1b_CleanCode_ReadFromFile
{
    public class ReverseTxtFile: IGetStringReverser
    {
        public string ReverseMyText(string textToReverse)
        {
            if (textToReverse == null)
                throw new ArgumentNullException();

            StringBuilder reversedText = new StringBuilder();
            for (int i = textToReverse.Length - 1; i >= 0; i--)
            {
                reversedText.Append(textToReverse[i]);
            }
            return reversedText.ToString();
        }

    }
}
