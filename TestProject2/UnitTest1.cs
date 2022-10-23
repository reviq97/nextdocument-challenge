using Microsoft.VisualStudio.TestPlatform.TestHost;
using ConsoleApp2;
using Program = ConsoleApp2.Program;

namespace TestProject2;

public class UnitTest1
{
    [Theory]
    [InlineData("AA-0000")]
    [InlineData("AB-5001")]
    [InlineData("AK-3212")]
    [InlineData("AR-4231")]
    [InlineData("BK-1234")]
    public void Increment_SingleNumber_ReturnsIncremented(string str)
    {
        //arrange
        var toIncrement = Program.GetNextDocumentNumber(str);

        //act 
        var split = str.Split('-');

        //assert
        Assert.Equal(int.Parse(split[1])+1, int.Parse(toIncrement.Split('-')[1]));
        
    }

    [Fact]
    public void Change_Letter_ReturnsChangedLetter()
    {
        //arrange
        string s = "AZ-9999";

        //act 
        var toIncrement = Program.GetNextDocumentNumber(s);

        //assert
        Assert.Equal("BZ-0000", toIncrement);
    }
    
    [Fact]
    public void Change_Letter_ReturnsChangedLetterTwo()
    {
        //arrange
        string s = "YZ-9999";

        //act 
        var toIncrement = Program.GetNextDocumentNumber(s);

        //assert
        Assert.Equal("ZZ-0000", toIncrement);
    }
    
    [Fact]
    public void Change_Letter_ReturnsChangedLetterThree()
    {
        //arrange
        string s = "ZZ-9999";

        //act 
        var toIncrement = Program.GetNextDocumentNumber(s);

        //assert
        Assert.Equal("AA-0000", toIncrement);
    }
}