using System;
using System.Collections.Generic;

namespace RepeatCounter.Objects
{
    public class RepeatCounter
    {
        public int CountRepeats(string sentence, string word)
        {
            int wordCounter = 0;
            string[] sentenceArray = sentence.Split(' ');
            string[] wordArray = word.Split(' ');
            for(int i = 0; i < wordArray.Length; i++)
            {
                for(int j = 0; j < sentenceArray.Length; j++)
                {
                    if(wordArray[i] == sentenceArray[j])
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
