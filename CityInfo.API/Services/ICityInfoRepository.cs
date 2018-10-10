using CityInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public interface ICityInfoRepository
    {
        bool CityExists(int cityId);
        // IQueryable vs IEnumerable
        // IQueryable > consumer of repo can keep building on an Iqueryable (add i clause, where clause etc). 
        // but will be leaking persistance related logic out of repo which seems to violate the purpose of the repo pattern
        // on other hand, if building api that allows a huge set of data shaping possibilities all requiring diff queries, it becomes cumbersome
        // We have straightforward API, so will return IEnumberable here.
        IEnumerable<City> GetCities();
        City GetCity(int cityId, bool includePointsOfInterest);
        IEnumerable<PointOfInterest> GetPointsOfInterestForCity(int cityId);
        PointOfInterest GetPointOfInterestForCity(int cityId, int pointOfInterestId);
    }
}
