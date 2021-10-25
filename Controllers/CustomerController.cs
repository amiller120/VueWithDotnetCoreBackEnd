
using Dapper;
using DotnetCoreBackEndVueSPAFrontEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace DotnetCoreBackEndVueSPAFrontEnd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly IDbConnection _dbConnection;
    public CustomerController(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    [HttpGet]
    public IEnumerable<Customer> Get()
    {
        const string sql = @"SELECT * FROM CUSTOMERS";
        return _dbConnection.Query<Customer>(sql);
    }

    [HttpGet("GetById")]
    public IEnumerable<Customer> GetById(int id)
    {
        return _dbConnection.Query<Customer>("SELECT * FROM Customers where Id = @id", new { id = id });
    }
}
