using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IOwnerRepository
    {
        SqlConnection Connection { get; }

        void AddOwner(Owner owner);
        void DeleteOwner(int ownerId);
        List<Owner> GetAll();
        Owner GetOwnerByEmail(string email);
        Owner GetOwnerById(int id);
        void UpdateOwner(Owner owner);
    }
}