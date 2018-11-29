using Microsoft.Extensions.Configuration;

namespace RestaurantPluralSight.Services
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public string GetMessageOfTheDay()
        {
            return "";
        }

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}