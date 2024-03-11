using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGO.DataAccess.Repository;
using RGO.DataAccess.Repository.IRepository;

namespace RGO.XunitIntegrationTests.ControllerTests
{
    // pass in the class that configures your application i.e. program.cs nb need to convert it
    // to a full Program class  and make it public so we have access to it
    public class CustomWebApplicationFactory: WebApplicationFactory<Program>    {

        public Mock<IGroup_TypeRepository> Group_TypeRepositoryMock { get; }

        public CustomWebApplicationFactory()
        {
            Group_TypeRepositoryMock = new Mock<IGroup_TypeRepository>();
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            base.ConfigureWebHost(builder);
            builder.ConfigureTestServices(services =>
            {
                services.AddSingleton(Group_TypeRepositoryMock.Object);
            });
        }
    }
}
