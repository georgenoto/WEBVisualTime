using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6022;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6022Controller : CatalogController<TABLE6022Dto, CreateTABLE6022Dto, UpdateTABLE6022Dto, int>
{
    public TABLE6022Controller(ITABLE6022Service service)
        : base(service, "TABLE6022", "NSOATCLASS", new[] { "NSOATCLASS", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
