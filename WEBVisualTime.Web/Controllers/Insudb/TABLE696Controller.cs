using WEBVisualTime.Servicios.Insudb.DTOs.TABLE696;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE696Controller : CatalogController<TABLE696Dto, CreateTABLE696Dto, UpdateTABLE696Dto, int>
{
    public TABLE696Controller(ITABLE696Service service)
        : base(service, "TABLE696", "NPOLICYSALE", new[] { "NPOLICYSALE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
