using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6785;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6785Controller : CatalogController<TABLE6785Dto, CreateTABLE6785Dto, UpdateTABLE6785Dto, int>
{
    public TABLE6785Controller(ITABLE6785Service service)
        : base(service, "TABLE6785", "NRISKTYPE", new[] { "NRISKTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
