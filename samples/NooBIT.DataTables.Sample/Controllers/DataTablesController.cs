using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NooBIT.DataTables.Language;
using NooBIT.DataTables.Models;
using NooBIT.DataTables.Sample.Model;

namespace NooBIT.DataTables.Sample.Controllers
{
    public class DataTablesController : Controller
    {
        private readonly IDataTable<SampleData> _sampleTable;
        private readonly ILoggerFactory _loggerFactory;

        private readonly Dictionary<string, LanguageSettings> Languages = new Dictionary<string, LanguageSettings>
        {
            { "de", LanguageSettings.German },
            { "en", LanguageSettings.English }
        };

        public DataTablesController(
            ILoggerFactory loggerFactory,
            IDataTable<SampleData> sampleTable)
        {
            _loggerFactory = loggerFactory;

            _sampleTable = sampleTable;
            _sampleTable.Error += OnError;
        }

        private Task OnError(object sender, DataTableErrorEventArgs eventArgs)
        {
            var logger = _loggerFactory.CreateLogger<ILogger>();
            logger.LogError(eventArgs.Exception, eventArgs.Exception.Message);
            return Task.CompletedTask;
        }

        [HttpPost("/")]
        public async Task<IActionResult> DataTable(DataTableRequest request, CancellationToken token)
        {
            var result = await _sampleTable.GetAsync(request, token);
            if (!string.IsNullOrWhiteSpace(result.Error))
                return BadRequest(result);
            return Ok(result);
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(_sampleTable);
        }

        [HttpGet("/language/{language}")]
        public IActionResult Language(string language)
        {
            // language parameter omitted
            // could be evaluated against dictionary or do whatever you want
            return Json(Languages[language], new JsonSerializerSettings { Formatting = Formatting.Indented });
        }
    }
}