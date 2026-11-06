using WEBVisualTime.Servicios.Insudb.DTOs.TABLE241;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE241Controller : CatalogController<TABLE241Dto, CreateTABLE241Dto, UpdateTABLE241Dto, int>
{
    public TABLE241Controller(ITABLE241Service service)
        : base(service, "TABLE241", "NRISKCLASS", new[] { "NRISKCLASS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
