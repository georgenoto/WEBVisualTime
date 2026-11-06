using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5612;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5612Controller : CatalogController<TABLE5612Dto, CreateTABLE5612Dto, UpdateTABLE5612Dto, int>
{
    public TABLE5612Controller(ITABLE5612Service service)
        : base(service, "TABLE5612", "NDAMAGE", new[] { "NDAMAGE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
