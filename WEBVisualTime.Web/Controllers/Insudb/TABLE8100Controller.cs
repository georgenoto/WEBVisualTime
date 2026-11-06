using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8100;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8100Controller : CatalogController<TABLE8100Dto, CreateTABLE8100Dto, UpdateTABLE8100Dto, int>
{
    public TABLE8100Controller(ITABLE8100Service service)
        : base(service, "TABLE8100", "NTYPE_CALC", new[] { "NTYPE_CALC", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
