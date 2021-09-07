using ContractWork.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContractWork.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]
  public class JobsController : ControllerBase
  {
    private readonly JobsService _js;

    public JobsController(JobsService js)
    {
      _js = js;
    }
    [HttpGet("/contractor/{id}")]
    public ActionResult<List<>>
  }
}