using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5647;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5647Controller : CatalogController<TABLE5647Dto, CreateTABLE5647Dto, UpdateTABLE5647Dto, int>
{
    public TABLE5647Controller(ITABLE5647Service service)
        : base(service, "TABLE5647", "NLIMIT_TYPE", new[] { "NLIMIT_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
