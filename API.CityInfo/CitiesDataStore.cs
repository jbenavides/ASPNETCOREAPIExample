using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.CityInfo.Models;

namespace API.CityInfo
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>
            {
                new CityDto
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park."
                },
                new CityDto
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "bla"
                },
                new CityDto
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "bla bla"
                }
            };
        }
    }
}
