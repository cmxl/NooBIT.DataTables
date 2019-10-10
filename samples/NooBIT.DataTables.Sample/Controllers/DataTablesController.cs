using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NooBIT.DataTables.Internationalization;
using NooBIT.DataTables.Models;
using NooBIT.DataTables.Sample.Model;
using NooBIT.DataTables.Sample.ViewModels;

namespace NooBIT.DataTables.Sample.Controllers
{
    public class DataTablesController : Controller
    {
        private readonly IDataTable<SampleData> _sampleTable;
        private readonly ILoggerFactory _loggerFactory;

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
            var viewModel = new SampleViewModel
            {
                Table = _sampleTable,
                Language = Language.German
            };

            return View(viewModel);
        }

        [HttpGet("/language/{language}")]
        public IActionResult Lang(string language)
        {
            return Json(Language.All.Value[language], new JsonSerializerSettings { Formatting = Formatting.Indented}); 
        }
    }
}