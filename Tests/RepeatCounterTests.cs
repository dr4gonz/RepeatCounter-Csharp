using System;
using System.Collections.Generic;
using Xunit;

namespace RepeatCounter.Objects
{
    public class RepeatCounterTests
    {
        // [Fact]
        // public void EnterStringOfCharactersAndSpecificCharacter_Return_NumOfTimesItAppears()
        // {
        //     RepeatCounter newCounter = new RepeatCounter();
        //     Assert.Equal(6, newCounter.CountRepeats("aaaaasddfsdfgjkgjkjhgkja","a"));
        // }
        // [Fact]
        // public void EnterWordAndSpecificCharacter_Return_NumOfTimesItAppears()
        // {
        //     RepeatCounter newCounter = new RepeatCounter();
        //     Assert.Equal(3, newCounter.CountRepeats("fluffy","f"));
        // }
        // [Fact]
        // public void EnterSentenceAndSpecificCharacter_Return_NumOfTimesItAppears()
        // {
        //     RepeatCounter newCounter = new RepeatCounter();
        //     Assert.Equal(5, newCounter.CountRepeats("The quick fluffy fox jumped over the lazy ferret","f"));
        // }
        [Fact]
        public void EnterSentenceAndWord_Return_NumOfTimesItAppears()
        {
            RepeatCounter newCounter = new RepeatCounter();
            Assert.Equal(3, newCounter.CountRepeats("one fox two fox three fox four","fox"));
        }
        [Fact]
        public void EnterSentenceWithSpecialCharactersAndWord_Return_NumOfTimesItAppears()
        {
            RepeatCounter newCounter = new RepeatCounter();
            Assert.Equal(3, newCounter.CountRepeats("one fox, two fox, three. fox, four!","fox"));
        }
    }
}
