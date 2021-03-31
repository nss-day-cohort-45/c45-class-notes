using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
        SqlConnection Connection { get; }

        void AddDog(Dog dog);
        void DeleteDog(int id, int ownerId);
        Dog GetDogById(int id, int ownerId);
        List<Dog> GetDogsByOwnerId(int ownerId);
        void UpdateDog(Dog dog);
    }
}