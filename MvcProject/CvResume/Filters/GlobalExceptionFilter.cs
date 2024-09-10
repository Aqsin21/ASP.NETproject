using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CvResume.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            // Hatanın detaylarını loglama işlemi yapılabilir.
            var exception = context.Exception;

            // Hata mesajı döndürme (JSON formatında ya da bir view ile yanıt verebilirsin)
            context.Result = new JsonResult(new
            {
                error = true,
                message = exception.Message
            })
            {
                StatusCode = 500 // Internal Server Error
            };

            context.ExceptionHandled = true; // Hata yönetildi olarak işaretlendi
        }

    }
}
