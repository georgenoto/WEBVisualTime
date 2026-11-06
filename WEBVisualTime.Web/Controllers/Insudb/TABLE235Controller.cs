using WEBVisualTime.Servicios.Insudb.DTOs.TABLE235;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE235Controller : CatalogController<TABLE235Dto, CreateTABLE235Dto, UpdateTABLE235Dto, string>
{
    public TABLE235Controller(ITABLE235Service service)
        : base(service, "TABLE235", "SDECLA_TYPE", new[] { "SDECLA_TYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
