using AutoMapper;
using IBO.Core.BusinessService.Api.Controllers;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Services;
using Moq;
using System.Collections.Generic;

namespace IBO.Core.BusineService.Api.Controller.Tests.SchoolControllerTests
{
    public abstract class BaseSchoolControllerTest
    {
        protected readonly ICollection<School> Items;
        protected readonly Mock<ISchoolService> MockSchoolService;
        protected readonly Mock<IMapper> MockMapper;
        protected readonly SchoolController ControllerUnderTest;

        protected BaseSchoolControllerTest(ICollection<School> items)
        {
            Items = items;
            MockSchoolService = new Mock<ISchoolService>();
            MockMapper = new Mock<IMapper>();
            MockSchoolService.Setup(svc => svc.GetAllSchoolAsync()).ReturnsAsync(Items);
            ControllerUnderTest = new SchoolController(MockSchoolService.Object, MockMapper.Object);
        }
    }
}
