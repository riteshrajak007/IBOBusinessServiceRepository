using IBO.Core.BusinessService.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace IBO.Core.BusineService.Api.Controller.Tests.SchoolControllerTests
{
    public class SchoolControllerTest : BaseSchoolControllerTest
    {
        private static readonly School FirstItem = new School() { Id = 1, Name = "First Item",Country="India" };
        private static readonly School SecondItem = new School() { Id = 2, Name = "Second Item" ,Country = "India" };
        public SchoolControllerTest() : base(new List<School>() { FirstItem, SecondItem })
        {
        }

        [Fact]
        public async Task GetAllSchoolAsyncShouldReturnListOfSchools()
        {
            var result = await ControllerUnderTest.GetAllSchoolAsync();

            var viewResult = Assert.IsType<Task<ICollection<School>>>(result);

            var model = Assert.IsAssignableFrom<ICollection<School>>(viewResult.Result);
            Assert.Equal(2, model.Count);
        }
    }
}
