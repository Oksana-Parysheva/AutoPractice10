using RestSharp;

namespace AutoPractice10.Services.Endpoints.Employee
{
    public static class EmployeeEndpoint
    {
        public static RestRequest GetEmployee()
        {
            return new RestRequest("employee", Method.GET);
        }
    }
}
