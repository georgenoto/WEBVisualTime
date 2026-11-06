using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5570;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5570Controller : CatalogController<TABLE5570Dto, CreateTABLE5570Dto, UpdateTABLE5570Dto, int>
{
    public TABLE5570Controller(ITABLE5570Service service)
        : base(service, "TABLE5570", "NTYPESUPPORT", new[] { "NTYPESUPPORT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
