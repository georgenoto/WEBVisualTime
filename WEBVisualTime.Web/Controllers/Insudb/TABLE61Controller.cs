using WEBVisualTime.Servicios.Insudb.DTOs.TABLE61;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE61Controller : CatalogController<TABLE61Dto, CreateTABLE61Dto, UpdateTABLE61Dto, int>
{
    public TABLE61Controller(ITABLE61Service service)
        : base(service, "TABLE61", "NORIGIN", new[] { "NORIGIN", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
