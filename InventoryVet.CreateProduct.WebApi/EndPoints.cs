using InventoryVet.ProductRegistration.BusinessObjects.DTOs.ProductRegistration;
using InventoryVet.ProductRegistration.BusinessObjects.Interfaces.Controllers;

namespace InventoryVet.CreateProduct.WebApi
{
    public static class EndPoints
    {
        public static WebApplication UseInventoryVetCreateProductEndPoints(
            this WebApplication app)
        {
            app.MapPost("/create",
                async (CreateProductDTO product,
                ICreateProductController controller) =>
                Results.Ok(await controller.CreateProduct(product)));

            return app;

        }
    }
}
