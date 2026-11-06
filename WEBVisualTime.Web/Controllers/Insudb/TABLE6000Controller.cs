using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6000;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6000Controller : CatalogController<TABLE6000Dto, CreateTABLE6000Dto, UpdateTABLE6000Dto, int>
{
    public TABLE6000Controller(ITABLE6000Service service)
        : base(service, "TABLE6000", "NTYPEOFADDRESS", new[] { "NTYPEOFADDRESS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "NUSERCODE", "SSTATREGT" }) { }
}
