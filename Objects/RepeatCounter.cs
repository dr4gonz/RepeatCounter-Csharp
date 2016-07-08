using System;
using System.Collections.Generic;

namespace RepeatCounter.Objects
{
    public class RepeatCounter
    {
        public int CountRepeats(string sentence, string word)
        {
            int characterCounter = 0;
            char[] sentenceArray = sentence.ToCharArray();
            char[] wordArray = word.ToCharArray();
            for(int i = 0; i < wordArray.Length; i++)
            {
                for(int j = 0; j < sentenceArray.Length; j++)
                {
                    if(wordArray[i] == sentenceArray[j])
                    {
                        characterCounter++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return characterCounter;
        }
    }
}
