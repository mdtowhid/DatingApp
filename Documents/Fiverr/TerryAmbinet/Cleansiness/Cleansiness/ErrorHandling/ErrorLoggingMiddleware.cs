using System.Text;

namespace Cleansiness.ErrorHandling
{
    public class ErrorLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _env;

        public ErrorLoggingMiddleware(RequestDelegate next, IWebHostEnvironment env)
        {
            _next = next;
            _env = env;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                StringBuilder sb = new StringBuilder();
                DateTimeOffset errorTime = DateTimeOffset.Now;
                string controllerName = context.Request.RouteValues["controller"].ToString();
                string actionName = context.Request.RouteValues["action"].ToString();

                sb.AppendLine($"=================Error At: {errorTime}=================")
                    .AppendLine($"Error Occured In {controllerName}Controller, Action: {actionName}")
                    .AppendLine($"Error: {e.Message}")
                    .AppendLine($"=================Error At: {errorTime}=================")
                    .AppendLine($"")
                    .AppendLine($"");

                string filePath = Path.Combine(_env.WebRootPath, "ErrorLog/ErrorLog.txt");


                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.Write(sb.ToString());
                    writer.Flush();
                }
                //System.Diagnostics.Debug.WriteLine($"The following error happened: {e.Message}");
                throw;
            }
        }
    }
}
