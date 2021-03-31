using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface INeighborhoodRepository
    {
        SqlConnection Connection { get; }

        List<Neighborhood> GetAll();
    }
}