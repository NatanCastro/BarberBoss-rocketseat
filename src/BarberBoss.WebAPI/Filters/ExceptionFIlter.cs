using BarberBoss.Communication.Responses;
using BarberBoss.Exception;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BarberBoss.WebAPI.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is BarberBossException)
        {
            HandleProjectExceptions(context);
        }
        else
        {
            HandleUnknownException(context);
        }
    }

    private static void HandleProjectExceptions(ExceptionContext context)
    {
        var barberBossException = (BarberBossException)context.Exception;

        var errorResponse = new ResponseErrorJson(barberBossException.GetErrors());

        context.HttpContext.Response.StatusCode = barberBossException.StatusCode;
        context.Result = new ObjectResult(errorResponse);
    }

    private static void HandleUnknownException(ExceptionContext context)
    {
        // TODO: Move error message to a resource file
        var errorResponse = new ResponseErrorJson("An unexpected error has occurred.");

        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(errorResponse);
    }
}
