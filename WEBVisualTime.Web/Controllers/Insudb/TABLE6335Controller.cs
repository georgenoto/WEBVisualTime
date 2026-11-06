using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6335;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6335Controller : CatalogController<TABLE6335Dto, CreateTABLE6335Dto, UpdateTABLE6335Dto, int>
{
    public TABLE6335Controller(ITABLE6335Service service)
        : base(service, "TABLE6335", "NTYPPREMRECOG", new[] { "NTYPPREMRECOG", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
