using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6805;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6805Controller : CatalogController<TABLE6805Dto, CreateTABLE6805Dto, UpdateTABLE6805Dto, int>
{
    public TABLE6805Controller(ITABLE6805Service service)
        : base(service, "TABLE6805", "NDATATYPE", new[] { "NDATATYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
