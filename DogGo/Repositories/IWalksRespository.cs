using DogGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Repositories
{
    public class IWalksRespository
    {
        List<Walk> GetAllWalks();
        Walk GetWalksById(int id);
        void AddWalks(Owner owner);
        void UpdateOwner(Owner owner);
        void DeleteOwner(int ownerId);
    }
}
