namespace Web.Models;

public class HomeService : IHomeService
{
    private readonly IHomeRepository _repository;

    public HomeService(IHomeRepository repository)
    {
        _repository = repository;
    }
    
    public int Add(int x, int y)
    {
        var list = _repository.FindAll();
        foreach (var emp in list)
        {
            Console.WriteLine(emp.Id + ":" + emp.Name);
        }
        int z = _repository.Count();
        return x + y + z;
    }
}