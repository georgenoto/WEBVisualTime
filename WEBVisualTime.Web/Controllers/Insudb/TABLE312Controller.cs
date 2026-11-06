using WEBVisualTime.Servicios.Insudb.DTOs.TABLE312;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE312Controller : CatalogController<TABLE312Dto, CreateTABLE312Dto, UpdateTABLE312Dto, int>
{
    public TABLE312Controller(ITABLE312Service service)
        : base(service, "TABLE312", "NLINK", new[] { "NLINK", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
