using WEBVisualTime.Servicios.Insudb.DTOs.H_ASSIGNMENT_PART;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class H_ASSIGNMENT_PARTController : CrudApiController<H_ASSIGNMENT_PARTDto, CreateH_ASSIGNMENT_PARTDto, UpdateH_ASSIGNMENT_PARTDto, long>
{
    public H_ASSIGNMENT_PARTController(IH_ASSIGNMENT_PARTService service) : base(service, dto => dto.NID_NUMREG) { }
}
