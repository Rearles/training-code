﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using AspNetCoreFundamentals.Filters;
using AspNetCoreFundamentals.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCoreFundamentals.Controllers
{
    [Route("[controller]")] // uses the current class's name as a variable of sorts. same as [Route("data")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly ILogger<DataController> _logger;

        public DataController(ILogger<DataController> logger)
        {
            logger.LogDebug(MethodBase.GetCurrentMethod().Name);
            _logger = logger;
        }

        [TypeFilter(typeof(TestingResourceFilter))]
        [TypeFilter(typeof(TestingExceptionFilter))]
        [TypeFilter(typeof(TestingActionFilter))]
        [TypeFilter(typeof(TestingResultFilter))]
        [HttpPost("filtertest")]
        public IActionResult FilterTest([TestingValidation] DataObject data)
        {
            _logger.LogDebug(MethodBase.GetCurrentMethod().Name);
            if (data.Id != 0)
            {
                throw new Exception("error");
            }
            return new EmptyResult();
        }

        //[HttpGet("1")] // GET data/1
        [HttpGet] // GET data
        public string GetData()
        {
            return "data";
        }

        [HttpGet("asdf/{id}")] // GET data/asdf/5
        public string GetDataWithId(int id)
        {
            return "data" + id;
        }

        // applying filters:
        //    - globally (adding them to the Filters collection inside the AddControllers call in Startup
        //    - per-controller (adding attribute on top of controller)
        //    - per-action (adding attribute on top of action method)

        // one downside of filters... because hey're applied with attributes and rely on asp.net core to
        // actually activate them, we can't unit test for the presence of the filters.
        //     we can unit test the filter, and the action method, but we'd need integration testing to verify they were combined together

        [HttpGet("2")] // GET data/2
        [HttpGet("3")] // GET data/3
        [HttpGet("4", Name = "data4")] // GET data/4
        //[Consumes(MediaTypeNames.Application.Xml)] // if this was a post/put/etc, we could restrict the model binding as well.
        //    (resource filter)
        //[Produces(MediaTypeNames.Application.Xml)]
        //    (result filter)
        public IActionResult GetData2()
        {
            // ContentResult, "low-level" way to customize a response with some body.
            var contentResult = new ContentResult
            {
                Content = "response body goes here",
                ContentType = "plain/text",
                StatusCode = StatusCodes.Status200OK
            };
            contentResult = Content("response body goes here"); // helper method from base class

            // StatusCodeResult, flexible way return any status code without a response body.
            var statusCodeResult = new StatusCodeResult(StatusCodes.Status200OK);
            statusCodeResult = StatusCode(StatusCodes.Status200OK); // helper method from base class

            // StatusCodeResult has many subclasses like AcceptedResult, OkResult, CreatedResult, BadRequestResult
            //     with their own helper methods

            var jsonResult = new JsonResult(new { Id = 1, Data = "data" },
                new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            //jsonResult = Json("asdf");

            var emptyResult = new EmptyResult(); // 200 OK, nothing in the body

            var fileResult = File("file.txt", "text/plain"); // helper method from base class for FileResult

            var redirectResult = Redirect("/data3"); // manual redirect to a hardcoded URL (RedirectResult)
            var redirectToActionResult = RedirectToAction(nameof(GetDataWithId), new { id = 4 }); // automatically calculates the right URL (DRY principle)
            var redirectToRouteResult = RedirectToRoute("data4"); // automatically calculates the right URL (DRY principle)

            var forbidResult = Forbid(); // special one just for 403 Forbidden (you don't have permissions)
            var data = new DataObject { Id = 1, Data = "data" };

            // objectresult return a body that supports content negotiation on how to serialize it
            // i.e. if the server supports JSON and XML, and the Accept header says XML, it will choose XML
            var objectResult = new ObjectResult(data) { StatusCode = StatusCodes.Status202Accepted };

            // ObjectResult has many subclasses like OkObjectResult, BadRequestObjectResult
            //     with their own helper methods

            var okObjectResult = Ok(data);

            // 201, with object in response body, and Location header for where the new resource can be accessed.
            var created = CreatedAtAction(nameof(GetDataWithId), new { id = data.Id }, data);

            return objectResult;
        }

        [HttpGet("abc/{id}")] // GET data/abc/5
        public ActionResult<DataObject> GetData5(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            return new DataObject { Id = id };
        }

        [HttpPost("abc")] // POST data/abc
        public IActionResult NewData(DataObject data)
        {
            return Ok();
        }
    }

    public class DataObject : IValidatableObject
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Data { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var logger = (ILogger<DataObject>)validationContext.GetService(typeof(ILogger<DataObject>));
            logger.LogDebug(MethodBase.GetCurrentMethod().Name);

            return Enumerable.Empty<ValidationResult>();
        }
    }
}
