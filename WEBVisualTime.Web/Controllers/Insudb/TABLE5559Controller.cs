using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5559;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5559Controller : CatalogController<TABLE5559Dto, CreateTABLE5559Dto, UpdateTABLE5559Dto, int>
{
    public TABLE5559Controller(ITABLE5559Service service)
        : base(service, "TABLE5559", "NRETARIF", new[] { "NRETARIF", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
