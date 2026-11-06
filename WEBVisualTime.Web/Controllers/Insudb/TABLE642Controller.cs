using WEBVisualTime.Servicios.Insudb.DTOs.TABLE642;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE642Controller : CatalogController<TABLE642Dto, CreateTABLE642Dto, UpdateTABLE642Dto, int>
{
    public TABLE642Controller(ITABLE642Service service)
        : base(service, "TABLE642", "NPROV_GROUP", new[] { "NPROV_GROUP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
