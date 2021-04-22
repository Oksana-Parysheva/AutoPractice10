using NUnit.Framework;
using RestSharp;

namespace AutoPractice10.Tests
{
    [SetUpFixture]
    public class TestFixture
    {
        private IRestClient _client;

        protected IRestClient Client
        {
            get
            {
                if (_client is null)
                {
                    _client = new RestClient("http://dummy.restapiexample.com/api/v1/").
                        AddDefaultHeader("Accept-Encoding", "gzip, deflate").
                        AddDefaultHeader("Accept", "application/json").
                        AddDefaultHeader("Accept-Language", "ru,en-US;q=0.9,en;q=0.8,ru-RU;q=0.7");
                }

                return _client;
            }
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
        }
    }
}
