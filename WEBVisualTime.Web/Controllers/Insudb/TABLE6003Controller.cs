using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6003;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6003Controller : CatalogController<TABLE6003Dto, CreateTABLE6003Dto, UpdateTABLE6003Dto, int>
{
    public TABLE6003Controller(ITABLE6003Service service)
        : base(service, "TABLE6003", "NFOUNDTYPE", new[] { "NFOUNDTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
