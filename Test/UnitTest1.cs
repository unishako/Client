using Moq;
using Web.Models;
using Xunit;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void モック無テスト()
    {
        IHomeService service = new HomeService(new HomeRepository());
        Assert.Equal(103, service.Add(1, 2));        
    }
    
    [Theory]
    [InlineData(258, 1, 2)]
    [InlineData(260, 2, 3)]
    public void モック有テスト(int expected, int x, int y)
    {
        var mock = new Mock<IHomeRepository>();
        mock.Setup(r => r.Count()).Returns(255);

        IHomeService service = new HomeService(mock.Object);
        Assert.Equal(expected, service.Add(x, y));
    }
}