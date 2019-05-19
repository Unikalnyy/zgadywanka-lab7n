using System;
using Xunit;
using ModelGry;

namespace TestUnitProjectModelGry
{
    public class UnitTest1
    {
        [Fact]
        public void Losuj_OK()
        {
            //arrange-act-assert = AAA

            //Arrange
            int min = 1;
            int max = 10;

            //Act
            int wylos = Gra.Losuj(min, max);

            Assert.True(wylos >= min && wylos <= max);
        }

    }
}
