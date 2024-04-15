using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.CommandHandlers;
using AmdarisEshop.Application.Commands;
using AmdarisEshop.Domain.Models;
using NSubstitute;

namespace AmdarisEshop.UnitTests.CommandHandlers
{
    public class CreateCategoryCommandHandlerTests
    {
        private readonly IUnitOfWork _unitOfWorkMock;

        public CreateCategoryCommandHandlerTests()
        {
            _unitOfWorkMock = Substitute.For<IUnitOfWork>();
        }

        [Fact]
        public async Task CreateCategory_ValidCommand_ShouldCreateCategory()
        {
            // Arrange
            var expectedCategory = new Category
            {
                CategoryId = 1,
                CategoryName = "category-1",
                CategoryDescription = "desc"
            };

            var handler = new CreateCategoryCommandHandler(_unitOfWorkMock);
            var command = new CreateCategory
            {
                CategoryName = expectedCategory.CategoryName,
                CategoryDescription = expectedCategory.CategoryDescription
            };

            // Act
            var actualResult = await handler.Handle(command, default);

            // Assert
            Assert.Equal(expectedCategory.CategoryName, actualResult.CategoryName);
            Assert.Equal(expectedCategory.CategoryDescription, actualResult.CategoryDescription);

            await _unitOfWorkMock.CategoryRepository.Received(1)
                .Add(Arg.Is<Category>(x =>
                    x.CategoryName == expectedCategory.CategoryName &&
                    x.CategoryDescription == expectedCategory.CategoryDescription));

            await _unitOfWorkMock.Received(1).Save();
        }
    }
}
