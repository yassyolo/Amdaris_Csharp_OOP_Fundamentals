using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Queries;
using AmdarisEshop.Application.QueryHandlers;
using AmdarisEshop.Domain.Models;
using NSubstitute;

namespace AmdarisEshop.UnitTests.QueryHandlers
{
    public class GetAllCategoriesHandlerTests
    {
        private readonly IUnitOfWork _unitOfWorkMock;

        public GetAllCategoriesHandlerTests()
        {
            _unitOfWorkMock = Substitute.For<IUnitOfWork>();
        }

        [Fact]
        public async Task GetAllCategories_WhenCategoriesExist_ShouldReturnAllCategories()
        {
            // Arrange
            var handler = new GetAllCategoriesHandler(_unitOfWorkMock);
            var query = new GetAllCategories();

            var expectedResult = new List<Category>
            {
                new() { CategoryId = 1, CategoryName = "category-1" },
                new() { CategoryId = 2, CategoryName = "category-2" }
            };

            _unitOfWorkMock.CategoryRepository.GetAll()
                .Returns(expectedResult);


            // Act
            var actualResult = await handler.Handle(query, default);

            // Assert
            Assert.Equal(expectedResult.Count, actualResult.Count);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.Equal(expectedResult[i].CategoryId, actualResult[i].CategoryId);
                Assert.Equal(expectedResult[i].CategoryName, actualResult[i].CategoryName);
            }

            await _unitOfWorkMock.CategoryRepository.Received(1).GetAll();
        }

        [Fact]
        public async Task GetAllCategories_WhenNoCategoriesExist_ShouldReturnEmptyList()
        {
            // Arrange
            var handler = new GetAllCategoriesHandler(_unitOfWorkMock);
            var query = new GetAllCategories();

            _unitOfWorkMock.CategoryRepository.GetAll()
                .Returns(Enumerable.Empty<Category>().ToList());

            // Act
            var actualResult = await handler.Handle(query, default);

            // Assert
            Assert.Empty(actualResult);
            await _unitOfWorkMock.CategoryRepository.Received(1).GetAll();
        }
    }
}