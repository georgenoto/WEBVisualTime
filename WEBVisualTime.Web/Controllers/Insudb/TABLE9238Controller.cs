using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9238;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9238Controller : CatalogController<TABLE9238Dto, CreateTABLE9238Dto, UpdateTABLE9238Dto, int>
{
    public TABLE9238Controller(ITABLE9238Service service)
        : base(service, "TABLE9238", "NORDERTYPE", new[] { "NORDERTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
