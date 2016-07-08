using System;
using System.Collections.Generic;
using Xunit;

namespace RepeatCounter.Objects
{
    public class RepeatCounterTests
    {
        public void EnterStringOfCharactersAndSpecificCharacter_Return_NumOfTimesItAppears()
        {
            RepeatCounter newCounter = new RepeatCounter();
            Assert.Equal(6, newCounter.CountRepeats("aaaaasddfsdfgjkgjkjhgkja","a"));
        }
        public void EnterWordAndSpecificCharacter_Return_NumOfTimesItAppears()
        {
            RepeatCounter newCounter = new RepeatCounter();
            Assert.Equal(3, newCounter.CountRepeats("fluffy","f"));
        }
    }
}
