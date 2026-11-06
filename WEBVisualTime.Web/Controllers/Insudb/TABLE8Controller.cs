using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8Controller : CatalogController<TABLE8Dto, CreateTABLE8Dto, UpdateTABLE8Dto, string>
{
    public TABLE8Controller(ITABLE8Service service)
        : base(service, "TABLE8", "SREINTYPE", new[] { "SREINTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
