using AutoPractice10.Services.Endpoints.Employee;
using AutoPractice10.Services.Extentions;
using AutoPractice10.Services.Models;
using NUnit.Framework;

namespace AutoPractice10.Tests
{
    public class ApiTests : TestFixture
    {
        [Test]
        [Category("API")]
        [Category("Employee")]
        [Category("Smoke")]
        public void GetEmployeeTest1()
        {
            var response = Client.Execute(EmployeeEndpoint.GetEmployee()).EnsureSuccess().As<Response>();
            Assert.That(response.Data.Count, Is.EqualTo(24));
        }
    }
}
