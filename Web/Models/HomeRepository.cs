using System.Data;
using Dapper;

namespace Web.Models;

public class HomeRepository : IHomeRepository
{
    private readonly IDbConnection _connection;

    public HomeRepository(IDbConnection connection)
    {
        _connection = connection;
    }
    
    public int Count() => 100;

    public IEnumerable<Emp> FindAll()
    {
        return _connection.Query<Emp>("SELECT * FROM client.emp");
    }
}