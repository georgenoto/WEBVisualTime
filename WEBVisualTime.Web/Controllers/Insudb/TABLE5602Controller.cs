using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5602;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5602Controller : CatalogController<TABLE5602Dto, CreateTABLE5602Dto, UpdateTABLE5602Dto, string>
{
    public TABLE5602Controller(ITABLE5602Service service)
        : base(service, "TABLE5602", "STYPETAX", new[] { "STYPETAX", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
