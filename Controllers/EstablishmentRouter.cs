using System;

namespace backend_test_dotnet_API.Controllers;

public static class EstablishmentRouter
{
    public static void AddEstablishmentRouter(this WebApplication app)
    {
        var router = app.MapGroup("estabelecimento");

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
