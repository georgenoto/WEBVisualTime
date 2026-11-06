using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6012;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6012Controller : CatalogController<TABLE6012Dto, CreateTABLE6012Dto, UpdateTABLE6012Dto, int>
{
    public TABLE6012Controller(ITABLE6012Service service)
        : base(service, "TABLE6012", "NDWELLINGTYPE", new[] { "NDWELLINGTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
