using WEBVisualTime.Servicios.Insudb.DTOs.CL_COMMERTYPEPAY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class CL_COMMERTYPEPAYController : CrudApiController<CL_COMMERTYPEPAYDto, CreateCL_COMMERTYPEPAYDto, UpdateCL_COMMERTYPEPAYDto, int>
{
    public CL_COMMERTYPEPAYController(ICL_COMMERTYPEPAYService service) : base(service, dto => dto.NTYPE_COMMPAY) { }
}
