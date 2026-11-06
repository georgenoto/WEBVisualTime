using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9203;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9203Controller : CatalogController<TABLE9203Dto, CreateTABLE9203Dto, UpdateTABLE9203Dto, int>
{
    public TABLE9203Controller(ITABLE9203Service service)
        : base(service, "TABLE9203", "NTYPELIST", new[] { "NTYPELIST", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE", "NTABLE9204" }) { }
}
