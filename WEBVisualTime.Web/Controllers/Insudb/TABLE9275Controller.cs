using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9275;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9275Controller : CatalogController<TABLE9275Dto, CreateTABLE9275Dto, UpdateTABLE9275Dto, int>
{
    public TABLE9275Controller(ITABLE9275Service service)
        : base(service, "TABLE9275", "NSTATUS", new[] { "NSTATUS", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
