namespace Web.Models;

public class HomeRepository : IHomeRepository
{
    public int Count()
    {
        return 100;
    }
}