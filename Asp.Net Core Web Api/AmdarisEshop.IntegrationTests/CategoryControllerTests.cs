using AmdarisEshop.Infrastructure;
using AmdarisEshop.Infrastructure.Repository;
using AmdarisEshop.IntegrationTests.Helpers;
using AmdarisEshop.Presentation.Controllers;
using AmdarisEshop.Presentation.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AmdarisEshop.IntegrationTests
{
    public class CategoryControllerTests
    {
        [Fact]
        public async Task CategoriesController_GetCategoriesFromDatabase_ReturnAllCategories()
        {
            // Arrange
            var numberOfCategories = 3;

            using var contextBuilder = new DataContextBuilder(); // create in-memory db
            contextBuilder.SeedCategories(numberOfCategories); // add data to db
            var dbContext = contextBuilder.GetContext();

            var categoryRepository = new CategoryRepository(dbContext);
            var productRepository = new ProductRepository(dbContext);
            var unitOfWork = new UnitOfWork(dbContext, productRepository, categoryRepository);

            var mapper = TestHelpers.CreateMapper();
            var mediator = TestHelpers.CreateMediator(unitOfWork);

            var controller = new CategoriesController(mapper, mediator);

            // Act
            var requestResult = await controller.GetCategories();

            // Assert
            var result = requestResult.Result as OkObjectResult;
            var categories = result!.Value as List<CategoryGetDto>;

            Assert.NotNull(result);
            Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);

            Assert.NotNull(categories);
            Assert.Equal(numberOfCategories, categories.Count);
        }
    }
}