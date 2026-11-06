using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6046;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6046Controller : CatalogController<TABLE6046Dto, CreateTABLE6046Dto, UpdateTABLE6046Dto, int>
{
    public TABLE6046Controller(ITABLE6046Service service)
        : base(service, "TABLE6046", "NCLI_CATEGORY", new[] { "NCLI_CATEGORY", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
