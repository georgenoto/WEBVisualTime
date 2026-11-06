using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5003;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5003Controller : CatalogController<TABLE5003Dto, CreateTABLE5003Dto, UpdateTABLE5003Dto, int>
{
    public TABLE5003Controller(ITABLE5003Service service)
        : base(service, "TABLE5003", "NREJECTCAUSE", new[] { "NREJECTCAUSE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
