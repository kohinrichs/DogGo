using DogGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Repositories
{
    public interface IWalksRespository
    {
        List<Walk> GetAllWalks();
        List<Walk> GetWalksByWalkerId(int walkerId);
        void AddWalk(Walk walk);
        void UpdateWalk(Walk walk);
        void DeleteWalk(int walkId);
    }
}
