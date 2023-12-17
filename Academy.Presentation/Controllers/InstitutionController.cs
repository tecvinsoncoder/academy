using Academy.Services.Contracts.Institutions;
using Academy.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Presentation.Controllers
{
    [Route("api/institutions")]
    [ApiController]
    public class InstitutionController : ControllerBase
    {
       private readonly ILogger<InstitutionController> _logger;
       private readonly IInstitutionService _institutionService;

       public InstitutionController(
        IInstitutionService institutionService,
        ILogger<InstitutionController> logger
        )
       {
        _institutionService = institutionService;
        _logger = logger;
       }

       [HttpPost]
       public ActionResult<InstitutionRsp<InstitutionDto>> Create(
        [FromBody]InstitutionCreateReq req)
       {
          return _institutionService.CreateInstitution(req);
       }
    }
}