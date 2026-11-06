using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5801;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5801Controller : CatalogController<TABLE5801Dto, CreateTABLE5801Dto, UpdateTABLE5801Dto, int>
{
    public TABLE5801Controller(ITABLE5801Service service)
        : base(service, "TABLE5801", "NTYPE_CALC", new[] { "NTYPE_CALC", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
