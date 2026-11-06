using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5555;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5555Controller : CatalogController<TABLE5555Dto, CreateTABLE5555Dto, UpdateTABLE5555Dto, int>
{
    public TABLE5555Controller(ITABLE5555Service service)
        : base(service, "TABLE5555", "NAGENCY", new[] { "NAGENCY", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
