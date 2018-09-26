using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NooBIT.DataTables.Models;
using NooBIT.DataTables.Sample.Model;

namespace NooBIT.DataTables.Sample.Controllers
{
    public class DataTablesController : Controller
    {
        private readonly IDataTable<SampleData> _sampleTable;

        public DataTablesController(IDataTable<SampleData> sampleTable)
        {
            _sampleTable = sampleTable;
        }

        [HttpPost("/datatable")]
        public async Task<IActionResult> DataTable(AjaxProcessingViewModel vm, CancellationToken token)
        {
            var result = await _sampleTable.GetAsync(vm, token);
            if (!string.IsNullOrWhiteSpace(result.Error))
                return BadRequest(result);
            return Ok(result);
        }

        [HttpGet("/datatable")]
        public IActionResult Index()
        {
            return View(_sampleTable);
        }
    }
}