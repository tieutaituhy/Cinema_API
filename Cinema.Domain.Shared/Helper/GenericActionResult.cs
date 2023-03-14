using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.Shared.Helper
{
    public class GenericActionResult : ActionResult, IActionResult
    {
        public int HttpStatusCode { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> Messages { get; set; }
        public object Data { get; set; }
        public int Total { get; set; }
        public int TotalDone { get; set; }
        public int TotalNotDone { get; set; }
        public int TotalLock { get; set; }
        public int TotalFilter { get; set; }

        public GenericActionResult()
        {
            Success = true;
            HttpStatusCode = 200;
        }

        public GenericActionResult(int status, bool success, string message = "", object data = null)
        {
            HttpStatusCode = status;
            Success = success;
            Message = message;
            Data = data;
        }

        public GenericActionResult(int status, bool success, List<string> messages, object data = null)
        {
            HttpStatusCode = status;
            Success = success;
            Messages = messages;
            Data = data;
        }

        public GenericActionResult(int status, string message, bool success, List<string> data = null)
        {
            HttpStatusCode = status;
            Success = success;
            Data = data;
        }

        public GenericActionResult(int total, object data)
        {
            Success = true;
            HttpStatusCode = 200;
            Total = total;
            Data = data;
        }

        public GenericActionResult(int total, int done, int notDone, object data)
        {
            Success = true;
            HttpStatusCode = 200;
            Total = total;
            TotalDone = done;
            TotalNotDone = notDone;
            Data = data;
        }

        public override async Task ExecuteResultAsync(ActionContext context)
        {
            ObjectResult objectResult;

            if (HttpStatusCode == 200)
                objectResult = new OkObjectResult(this);
            else if (HttpStatusCode == 404)
                objectResult = new NotFoundObjectResult(this);
            else if (HttpStatusCode == 400)
                objectResult = new BadRequestObjectResult(this);
            else
                objectResult = new ObjectResult(this);

            await objectResult.ExecuteResultAsync(context);
        }
        public GenericActionResult(int total, int done, int notDone, int locked, object data)
        {
            Success = true;
            HttpStatusCode = 200;
            Total = total;
            TotalDone = done;
            TotalNotDone = notDone;
            TotalLock = locked;
            Data = data;
        }
        public GenericActionResult(int total, int done, int notDone, int locked, int totalFilter, object data)
        {
            Success = true;
            HttpStatusCode = 200;
            Total = total;
            TotalDone = done;
            TotalNotDone = notDone;
            TotalLock = locked;
            TotalFilter = totalFilter;
            Data = data;
        }
    }
}
