using WEBVisualTime.Servicios.Insudb.DTOs.CL_COMMERTYPEPAY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CL_COMMERTYPEPAYController : CatalogController<CL_COMMERTYPEPAYDto, CreateCL_COMMERTYPEPAYDto, UpdateCL_COMMERTYPEPAYDto, int>
{
    public CL_COMMERTYPEPAYController(ICL_COMMERTYPEPAYService service)
        : base(service, "CL_COMMERTYPEPAY", "NTYPE_COMMPAY", new[] { "NTYPE_COMMPAY", "SDESCRIPT", "SIND_CONTROL", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
