using Microsoft.Extensions.Configuration;

namespace NetCore01
{
    public interface IExternalInformation
    {
        object GetInformationForTheDay();
    }

    public class ExternalInformation : IExternalInformation
    {
        private IConfiguration _configuration;
        public ExternalInformation(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        public object GetInformationForTheDay()
        {
            return _configuration["Greeting"];
        }
    }
}