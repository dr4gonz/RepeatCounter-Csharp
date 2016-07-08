using System;
using System.Collections.Generic;

namespace RepeatCounter.Objects
{
    public class RepeatCounter
    {
        public int CountRepeats(string sentence, string word)
        {
            int wordCounter = 0;
            char[] delim = new char[]{' ',',','.',':',';','"'};
            string[] sentenceArray = sentence.Split(delim);
            string[] wordArray = word.Split(delim);

            for(int i = 0; i < wordArray.Length; i++)
            {
                for(int j = 0; j < sentenceArray.Length; j++)
                {
                    if(wordArray[i].ToLower() == sentenceArray[j].ToLower())
                    {
                        wordCounter++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return wordCounter;
        }
    }
}
