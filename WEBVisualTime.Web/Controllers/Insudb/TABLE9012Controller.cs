using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9012;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9012Controller : CatalogController<TABLE9012Dto, CreateTABLE9012Dto, UpdateTABLE9012Dto, int>
{
    public TABLE9012Controller(ITABLE9012Service service)
        : base(service, "TABLE9012", "NTYPECIA", new[] { "NTYPECIA", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
