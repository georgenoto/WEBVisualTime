using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5506;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5506Controller : CatalogController<TABLE5506Dto, CreateTABLE5506Dto, UpdateTABLE5506Dto, int>
{
    public TABLE5506Controller(ITABLE5506Service service)
        : base(service, "TABLE5506", "NHOBBY", new[] { "NHOBBY", "SDESCRIPT", "SSHORT_DES", "DCOMPDATE", "SSTATREGT", "NUSERCODE" }) { }
}
