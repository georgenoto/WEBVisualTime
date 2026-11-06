using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8030;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8030Controller : CatalogController<TABLE8030Dto, CreateTABLE8030Dto, UpdateTABLE8030Dto, int>
{
    public TABLE8030Controller(ITABLE8030Service service)
        : base(service, "TABLE8030", "NREPTYPE", new[] { "NREPTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
