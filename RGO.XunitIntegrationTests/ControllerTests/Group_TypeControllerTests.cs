using NPOI.SS.Formula.Functions;
using RGO;
using RGO.Models;
using RGO.DataAccess.Repository;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models.Models;
using System.Net;
using Xunit;



namespace RGO.XunitIntegrationTests.ControllerTests
{
    public class Group_TypeControllerTests : IDisposable
    {

        private CustomWebApplicationFactory _factory;
        private HttpClient _client;

        public Group_TypeControllerTests()
        {
            _factory = new CustomWebApplicationFactory();
            _client = _factory.CreateClient();  // this gives us a kind of fake HTTP client
        }

        [Fact]

        public async Task Get_Returns_Records()
        {

            var mockGroup_Types = new Group_Type[]
            {
                new(){ Id = 1, Name = "Research Group X", Created_By = "seed", Created_Date = DateTime.Now },
                new(){ Id = 2, Name = "Data Team X", Created_By = "seed", Created_Date = DateTime.Now }
            }.AsQueryable();

        //    _factory.Group_TypeRepositoryMock.Setup(r => r.GetAll).Returns(mockGroup_Types);


            var response = _client.GetAsync("/Config/Group_Type/");

      //      Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }


        public void Dispose()
        {
            _client.Dispose();
            _factory.Dispose();
        }
    }


}
