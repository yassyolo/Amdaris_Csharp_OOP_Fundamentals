using AmdarisEshop.Application.Commands;
using AmdarisEshop.Domain.Models;
using AmdarisEshop.Presentation.Controllers;
using AmdarisEshop.Presentation.Dto;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;

namespace AmdarisEshop.UnitTests.ControllerTests
{
    public class CategoriesControllerTests
    {
        private readonly IMapper _mapperMock;
        private readonly IMediator _mediatorMock;

        public CategoriesControllerTests()
        {
            _mapperMock = Substitute.For<IMapper>();
            _mediatorMock = Substitute.For<IMediator>();
        }

        [Fact]
        public async Task CreateCategory_ValidModelState_ReturnsCreatedAtAction()
        {
            // Arrange
            var controller = new CategoriesController(_mapperMock, _mediatorMock);

            var categoryDto = new CategoryPutPostDto
            {
                CategoryName = "category-1"
            };

            _mapperMock.Map<CategoryGetDto>(Arg.Any<Category>())
                .Returns(new CategoryGetDto { CategoryName = categoryDto.CategoryName });

            // Act
            var result = await controller.CreateCategory(categoryDto);

            // Assert
            Assert.IsType<CreatedAtActionResult>(result);
            await _mediatorMock.Received(1).Send(Arg.Any<CreateCategory>());
        }

        [Fact]
        public async Task CreateCategory_InvalidModelState_ReturnsBadRequest()
        {
            // Arrange
            var controller = new CategoriesController(_mapperMock, _mediatorMock);

            var categoryDto = new CategoryPutPostDto();

            // Manually add model error to simulate invalid model state
            controller.ModelState.AddModelError(
                nameof(categoryDto.CategoryName),
                "Required");

            // Act
            var result = await controller.CreateCategory(categoryDto);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
            await _mediatorMock.DidNotReceive().Send(Arg.Any<CreateCategory>());
        }
    }
}
