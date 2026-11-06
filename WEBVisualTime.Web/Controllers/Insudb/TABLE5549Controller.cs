using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5549;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5549Controller : CatalogController<TABLE5549Dto, CreateTABLE5549Dto, UpdateTABLE5549Dto, int>
{
    public TABLE5549Controller(ITABLE5549Service service)
        : base(service, "TABLE5549", "NINCAPACITY", new[] { "NINCAPACITY", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
