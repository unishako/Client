using Moq;
using Web.Models;
using Xunit;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void 加算テスト1()
    {
        IHomeService service = new HomeService(new HomeRepository());
        Assert.Equal(103, service.Add(1, 2));        
    }
    
    [Fact]
    public void 加算テスト2()
    {
        var mock = new Mock<IHomeRepository>();
        mock.Setup(r => r.Count()).Returns(255);

        IHomeService service = new HomeService(mock.Object);
        Assert.NotEqual(103, service.Add(1, 2));
        Assert.Equal(258, service.Add(1, 2));
    }
}