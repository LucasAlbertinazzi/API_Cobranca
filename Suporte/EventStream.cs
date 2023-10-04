using Microsoft.AspNetCore.Mvc;

namespace API_AppCobranca.Suporte
{
    public class EventStream : IActionResult
    {
        private readonly Func<HttpResponse, CancellationToken, Task> _onExecuting;
        private readonly string _contentType;

        public EventStream(Func<HttpResponse, CancellationToken, Task> onExecuting, string contentType)
        {
            _onExecuting = onExecuting ?? throw new ArgumentNullException(nameof(onExecuting));
            _contentType = contentType ?? throw new ArgumentNullException(nameof(contentType));
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var response = context.HttpContext.Response;
            response.Headers.Add("Cache-Control", "no-cache");
            response.Headers.Add("Connection", "keep-alive");
            response.ContentType = _contentType;

            await _onExecuting(response, context.HttpContext.RequestAborted);
        }
    }

}
