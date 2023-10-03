using FindLargestNumberAPI.Models;

namespace FindLargestNumberAPI
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore() {
            Cities = new List<CityDto>(){new CityDto { Id =1, Name ="NewYork", Description = "Busy one"} ,
            new CityDto{Id = 2, Name ="Antworp", Description ="Cathedral City"},
            new CityDto{Id = 3, Name ="Paris", Description ="Tower City"}};
        }
    }
}
