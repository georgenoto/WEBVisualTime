using WEBVisualTime.Servicios.Insudb.DTOs.TABLE526;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE526Controller : CatalogController<TABLE526Dto, CreateTABLE526Dto, UpdateTABLE526Dto, int>
{
    public TABLE526Controller(ITABLE526Service service)
        : base(service, "TABLE526", "NTYPE_PROCE", new[] { "NTYPE_PROCE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
