using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5770;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5770Controller : CatalogController<TABLE5770Dto, CreateTABLE5770Dto, UpdateTABLE5770Dto, int>
{
    public TABLE5770Controller(ITABLE5770Service service)
        : base(service, "TABLE5770", "NSPECIALBUSINES", new[] { "NSPECIALBUSINES", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
