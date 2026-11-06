using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9248;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9248Controller : CatalogController<TABLE9248Dto, CreateTABLE9248Dto, UpdateTABLE9248Dto, int>
{
    public TABLE9248Controller(ITABLE9248Service service)
        : base(service, "TABLE9248", "NSTATUS", new[] { "NSTATUS", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
