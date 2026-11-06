using WEBVisualTime.Servicios.Insudb.DTOs.TABLE98;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE98Controller : CatalogController<TABLE98Dto, CreateTABLE98Dto, UpdateTABLE98Dto, int>
{
    public TABLE98Controller(ITABLE98Service service)
        : base(service, "TABLE98", "NTYPE_REPORT", new[] { "NTYPE_REPORT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
