using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5541;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5541Controller : CatalogController<TABLE5541Dto, CreateTABLE5541Dto, UpdateTABLE5541Dto, int>
{
    public TABLE5541Controller(ITABLE5541Service service)
        : base(service, "TABLE5541", "NLEVEL_SECTOR", new[] { "NLEVEL_SECTOR", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
