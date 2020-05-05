using AutoMapper;
using IBO.Core.BusinessService.Api.Controllers;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusineService.Api.Controller.Tests.SchoolControllerTests
{
    public abstract class BaseSchoolControllerTest
    {
        protected readonly List<School> Items;
        protected readonly Mock<ISchoolService> MockSchoolService;
        protected readonly Mock<IMapper> MockMapper;
        protected readonly SchoolController ControllerUnderTest;

        protected BaseSchoolControllerTest(List<School> items)
        {
            //Items = items;
            //MockService = new Mock<ISchoolService>();
            //MockService.Setup(svc => svc.GetItemsAsync())
            //    .ReturnsAsync(Items);
            //ControllerUnderTest = new ToDoController(MockService.Object);
        }
    }
}
