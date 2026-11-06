using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9244;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9244Controller : CatalogController<TABLE9244Dto, CreateTABLE9244Dto, UpdateTABLE9244Dto, int>
{
    public TABLE9244Controller(ITABLE9244Service service)
        : base(service, "TABLE9244", "NACTIONCLAIM", new[] { "NACTIONCLAIM", "SDESCRIPT", "SSHORT_DES", "SSTATREG", "DCOMPDATE", "NUSERCODE" }) { }
}
