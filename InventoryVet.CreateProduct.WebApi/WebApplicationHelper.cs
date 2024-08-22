using InventoriVet.Create.Product.InversionOfControl;

namespace InventoryVet.CreateProduct.WebApi
{
    public static class WebApplicationHelper
    {
        public static WebApplication CreateWebApplication(
            
            this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddInventoriVetCreateProductServices(
                builder.Configuration, "InventoryVetDB");

            return builder.Build();
        }

        public static WebApplication ConfigureWebApplication(
            this WebApplication app)
        {
            if (app.Environment.IsDevelopment()) 
            { 
            app.UseSwagger();
            app.UseSwaggerUI();   
            }

            app.UseInventoryVetCreateProductEndPoints();

            return app;
        }

    }
}
