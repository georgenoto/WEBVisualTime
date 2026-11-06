using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8004;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8004Controller : CatalogController<TABLE8004Dto, CreateTABLE8004Dto, UpdateTABLE8004Dto, int>
{
    public TABLE8004Controller(ITABLE8004Service service)
        : base(service, "TABLE8004", "NTYPEPOP", new[] { "NTYPEPOP", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
