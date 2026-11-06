using WEBVisualTime.Servicios.Insudb.DTOs.TABLE512;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE512Controller : CatalogController<TABLE512Dto, CreateTABLE512Dto, UpdateTABLE512Dto, int>
{
    public TABLE512Controller(ITABLE512Service service)
        : base(service, "TABLE512", "NSPORT", new[] { "NSPORT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
