using WEBVisualTime.Servicios.Insudb.DTOs.TABLE211;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE211Controller : CatalogController<TABLE211Dto, CreateTABLE211Dto, UpdateTABLE211Dto, int>
{
    public TABLE211Controller(ITABLE211Service service)
        : base(service, "TABLE211", "NIN_LIF_TYP", new[] { "NIN_LIF_TYP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
