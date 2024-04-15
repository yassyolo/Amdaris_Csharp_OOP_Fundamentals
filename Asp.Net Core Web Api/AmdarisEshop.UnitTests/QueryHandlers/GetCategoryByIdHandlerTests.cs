using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Queries;
using AmdarisEshop.Application.QueryHandlers;
using AmdarisEshop.Domain.Models;
using NSubstitute;
using NSubstitute.ReturnsExtensions;

namespace AmdarisEshop.UnitTests.QueryHandlers
{
    public class GetCategoryByIdHandlerTests
    {
        private readonly IUnitOfWork _unitOfWorkMock;

        public GetCategoryByIdHandlerTests()
        {
            _unitOfWorkMock = Substitute.For<IUnitOfWork>();
        }

        [Fact]
        public async Task GetCategoryById_WithExistingCategoryId_ShouldReturnCategory()
        {
            // Arrange
            var categoryId = 1;
            var handler = new GetCategoryByIdHandler(_unitOfWorkMock);
            var query = new GetCategoryById { CategoryId = categoryId };

            var expectedResult = new Category { CategoryId = categoryId, CategoryName = "category-1" };

            _unitOfWorkMock.CategoryRepository.GetById(Arg.Any<int>())
                .Returns(expectedResult);

            // Act
            var actualResult = await handler.Handle(query, default);

            // Assert
            Assert.Equal(expectedResult.CategoryId, actualResult.CategoryId);
            Assert.Equal(expectedResult.CategoryName, actualResult.CategoryName);

            await _unitOfWorkMock.CategoryRepository.Received(1).GetById(Arg.Is<int>(x => x == categoryId));
        }

        [Fact]
        public async Task GetCategoryById_WithNonExistingCategoryId_ShouldReturnNull()
        {
            // Arrange
            var nonExitingCategoryId = 0;
            var handler = new GetCategoryByIdHandler(_unitOfWorkMock);
            var query = new GetCategoryById { CategoryId = nonExitingCategoryId };

            _unitOfWorkMock.CategoryRepository.GetById(Arg.Any<int>())
                .ReturnsNull();

            // Act
            var actualResult = await handler.Handle(query, default);

            // Assert
            Assert.Null(actualResult);

            await _unitOfWorkMock.CategoryRepository.Received(1).GetById(Arg.Is<int>(x => x == nonExitingCategoryId));
        }
    }
}
