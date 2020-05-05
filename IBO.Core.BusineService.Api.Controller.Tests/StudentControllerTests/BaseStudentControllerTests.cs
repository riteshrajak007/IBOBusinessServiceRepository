using AutoMapper;
using IBO.Core.BusinessService.Api.Controllers;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Services;
using Moq;
using System.Collections.Generic;

namespace IBO.Core.BusineService.Api.Controller.Tests.StudentControllerTests
{
    public abstract class BaseStudentControllerTests
    {
        protected readonly ICollection<Student> Items;
        protected readonly Mock<IStudentService> MockStudentService;
        protected readonly Mock<IMapper> MockMapper;
        protected readonly StudentController ControllerUnderTest;

        protected BaseStudentControllerTests(ICollection<Student> items)
        {
            Items = items;
            MockStudentService = new Mock<IStudentService>();
            MockMapper = new Mock<IMapper>();
            MockStudentService.Setup(svc => svc.GetAllStudentAsync()).ReturnsAsync(Items);
            ControllerUnderTest = new StudentController(MockStudentService.Object, MockMapper.Object);
        }
    }
}
