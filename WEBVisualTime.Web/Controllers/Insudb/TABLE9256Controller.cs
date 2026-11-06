using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9256;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9256Controller : CatalogController<TABLE9256Dto, CreateTABLE9256Dto, UpdateTABLE9256Dto, int>
{
    public TABLE9256Controller(ITABLE9256Service service)
        : base(service, "TABLE9256", "NCOD_MEDCOLLEGE", new[] { "NCOD_MEDCOLLEGE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
