using System;
using System.Collections.Generic;
using Xunit;

namespace RepeatCounter.Objects
{
    public class RepeatCounterTests
    {
        [Fact]
        public void EnterStringOfCharactersAndSpecificCharacter_Return_NumOfTimesItAppears()
        {
            RepeatCounter newCounter = new RepeatCounter();
            Assert.Equal(6, newCounter.CountRepeats("aaaaasddfsdfgjkgjkjhgkja","a"));
        }
        [Fact]
        public void EnterWordAndSpecificCharacter_Return_NumOfTimesItAppears()
        {
            RepeatCounter newCounter = new RepeatCounter();
            Assert.Equal(3, newCounter.CountRepeats("fluffy","f"));
        }
    }
}
