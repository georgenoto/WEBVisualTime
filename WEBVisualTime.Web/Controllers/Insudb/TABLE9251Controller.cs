using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9251;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9251Controller : CatalogController<TABLE9251Dto, CreateTABLE9251Dto, UpdateTABLE9251Dto, int>
{
    public TABLE9251Controller(ITABLE9251Service service)
        : base(service, "TABLE9251", "NPAYEE", new[] { "NPAYEE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
