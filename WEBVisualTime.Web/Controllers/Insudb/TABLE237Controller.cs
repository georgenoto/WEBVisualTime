using WEBVisualTime.Servicios.Insudb.DTOs.TABLE237;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE237Controller : CatalogController<TABLE237Dto, CreateTABLE237Dto, UpdateTABLE237Dto, int>
{
    public TABLE237Controller(ITABLE237Service service)
        : base(service, "TABLE237", "NPACKING", new[] { "NPACKING", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
