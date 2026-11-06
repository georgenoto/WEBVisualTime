using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5526;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5526Controller : CatalogController<TABLE5526Dto, CreateTABLE5526Dto, UpdateTABLE5526Dto, int>
{
    public TABLE5526Controller(ITABLE5526Service service)
        : base(service, "TABLE5526", "NSTATQUOTA", new[] { "NSTATQUOTA", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
