using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5701;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5701Controller : CatalogController<TABLE5701Dto, CreateTABLE5701Dto, UpdateTABLE5701Dto, int>
{
    public TABLE5701Controller(ITABLE5701Service service)
        : base(service, "TABLE5701", "NFORMAT", new[] { "NFORMAT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
