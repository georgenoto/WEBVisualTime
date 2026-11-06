using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6786;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6786Controller : CatalogController<TABLE6786Dto, CreateTABLE6786Dto, UpdateTABLE6786Dto, int>
{
    public TABLE6786Controller(ITABLE6786Service service)
        : base(service, "TABLE6786", "NDEFTYPE", new[] { "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "NUSERCODE", "NDEFTYPE", "SSTATREGT" }) { }
}
