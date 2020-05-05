using IBO.Core.BusinessService.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace IBO.Core.BusineService.Api.Controller.Tests.StudentControllerTests
{
    public class StudentControllerTest : BaseStudentControllerTests
    {
        private static readonly Student FirstItem = new Student() { Id = 1, Name = "First Item", Country = "India" };
        private static readonly Student SecondItem = new Student() { Id = 2, Name = "Second Item", Country = "India" };
        public StudentControllerTest() : base(new List<Student>() { FirstItem, SecondItem })
        {
        }

        [Fact]
        public async Task GetAllStudentAsyncShouldReturnListOfStudents()
        {
            var result = await ControllerUnderTest.GetAllStudentAsync();

            var viewResult = Assert.IsType<Task<ICollection<Student>>>(result);

            var model = Assert.IsAssignableFrom<ICollection<Student>>(viewResult.Result);
            Assert.Equal(2, model.Count);
        }
    }
}
