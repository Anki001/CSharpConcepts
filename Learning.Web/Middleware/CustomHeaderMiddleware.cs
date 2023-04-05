namespace Learning.Web.Middleware
{
    public class CustomHeaderMiddleware : IMiddleware
    {        
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // Add the custom header to the response            
            context.Response.Headers.Add("X-Custom-Header", "MyValue");

            //Call the next middleware in the pipeline
            await next.Invoke(context);
        }
    }
}
