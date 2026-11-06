using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8003;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8003Controller : CatalogController<TABLE8003Dto, CreateTABLE8003Dto, UpdateTABLE8003Dto, int>
{
    public TABLE8003Controller(ITABLE8003Service service)
        : base(service, "TABLE8003", "NTYPROUTE", new[] { "NTYPROUTE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
