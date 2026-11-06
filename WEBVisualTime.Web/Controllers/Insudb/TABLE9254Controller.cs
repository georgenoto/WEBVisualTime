using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9254;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9254Controller : CatalogController<TABLE9254Dto, CreateTABLE9254Dto, UpdateTABLE9254Dto, int>
{
    public TABLE9254Controller(ITABLE9254Service service)
        : base(service, "TABLE9254", "NTYPEDISC_PROV", new[] { "NTYPEDISC_PROV", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
