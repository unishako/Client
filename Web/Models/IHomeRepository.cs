namespace Web.Models;

public interface IHomeRepository
{
    int Count();

    IEnumerable<Emp> FindAll();
}