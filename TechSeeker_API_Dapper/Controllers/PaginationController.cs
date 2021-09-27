using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using TechSeeker_API_Dapper.Models;

namespace TechSeeker_API_Dapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaginationController : ControllerBase
    {
        private readonly IConfiguration _config;

        public PaginationController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAngajati(int currentPageNumber, int pageSize)
        {
            int maxPageSize = 50;
            pageSize = pageSize < maxPageSize ? pageSize : maxPageSize;

            int skip = (currentPageNumber - 1) * pageSize;
            int take = pageSize;

            using var connection = new SqlConnection(_config.GetConnectionString("AppTestSrv"));
            var reader = await connection.QueryMultipleAsync("sp_Pagination",
                                                             new { Skip = skip, Take = take },
                                                             commandType: CommandType.StoredProcedure);

            int totalCount = reader.Read<int>().FirstOrDefault();
            var angajati = reader.Read<Angajat>().ToList();

            var result = new PaginationResponse<List<Angajat>>(totalCount, angajati, currentPageNumber, pageSize);
            return Ok(result);
        }
    }
}
