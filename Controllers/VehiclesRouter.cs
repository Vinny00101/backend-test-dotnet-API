using System;

namespace backend_test_dotnet_API.Controllers;

public static class VehiclesRouter
{
    public static void AddVehiclesRouter(this WebApplication app)
    {
        var router = app.MapGroup("veiculos");

        router.MapPost("adicionar", () => {

        });

        router.MapGet("buscar", () => {

        });

        router.MapPut("editar", () => {

        });

        router.MapDelete("remove", () => {

        });
    }
}
