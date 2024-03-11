using RGO;
using Microsoft.AspNetCore.Mvc.Testing;
using RGO.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository.IRepository;
using Microsoft.CodeAnalysis.CSharp;
using NPOI.HSSF.Record;
namespace RGO.XUnitTests
{
    public class UnitTest1: IClassFixture<WebApplicationFactory<Program>>
    {

        private readonly WebApplicationFactory<Program> _factory;
        private readonly HttpClient httpClient;


        //default constructor
        public UnitTest1()
        {
            var factory = new WebApplicationFactory<Program>();
            _factory = factory;
            httpClient = _factory.CreateClient();
            
            
            UnitOfWork _UnitOfWork;
            int newPK;
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            ///* Tell JRF to fix this */
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=R-GO;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            var dbContext = new ApplicationDbContext(optionsBuilder.Options);
            _UnitOfWork = new UnitOfWork(dbContext);

        }

            [Fact(Skip = "Moved test to Theory")]
            public async void Group_Type_Index_Loads()
            {
                //Arrange
                //var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

                ///* Tell JRF to fix this */

                //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=R-GO;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

                //var dbContext = new ApplicationDbContext(optionsBuilder.Options);

                //_UnitOfWork = new UnitOfWork(dbContext);

                var client = _factory.CreateClient();



                //Act
                var response = await client.GetAsync("Config/Group_Type/Index");
                int code = (int)response.StatusCode;



                //Assert

                Assert.Equal(200, code);


            }
            [Theory]
            [InlineData("/", 200)]
            [InlineData("/Config/Home/Privacy", 200)]
            [InlineData("/Config/Group_Type", 200)]
            [InlineData("/Config/Group", 200)]
            [InlineData("/Config/RGO_Type", 200)]
            [InlineData("/Config/RGOutput", 200)]
            [InlineData("/Config/RGO_Dataset_Template", 200)]
            [InlineData("/Config/RGO_Column_Template", 200)]
            [InlineData("/Config/Datasets", 200)]
            [InlineData("/Config/Upload/Upload", 200)]
            [InlineData("/Config/Invalid_link", 404)] 

        public async void AllPagesLoad(string URL, int expectedResult)
            {
                //Arrange
                
                var client = _factory.CreateClient();

                //Act
                var response = await client.GetAsync(URL);
                int code = (int)response.StatusCode;

                //Assert
                Assert.Equal(expectedResult, code);

            }

        [Theory]
        [InlineData("Research")]
        [InlineData("Data")]
        [InlineData("Suzie")]

        //Search the content of the groups Index page -- this isn't working for me!
        public async Task TestForGroups(string groupName)
        {

            //Arrange 


            //Act
            var response = await httpClient.GetAsync("/Config/Group");
            var pageContent = await response.Content.ReadAsStringAsync();
            var contentString = pageContent.ToString();

            //Assert
            Assert.Contains(groupName, contentString);
        }
    }
}