using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5561;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5561Controller : CatalogController<TABLE5561Dto, CreateTABLE5561Dto, UpdateTABLE5561Dto, int>
{
    public TABLE5561Controller(ITABLE5561Service service)
        : base(service, "TABLE5561", "NSTATUSROL", new[] { "NSTATUSROL", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
