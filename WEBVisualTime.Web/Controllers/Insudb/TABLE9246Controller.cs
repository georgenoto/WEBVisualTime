using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9246;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9246Controller : CatalogController<TABLE9246Dto, CreateTABLE9246Dto, UpdateTABLE9246Dto, int>
{
    public TABLE9246Controller(ITABLE9246Service service)
        : base(service, "TABLE9246", "NCOD_REJECT", new[] { "NCOD_REJECT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
