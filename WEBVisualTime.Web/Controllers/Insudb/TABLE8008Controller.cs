using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8008;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8008Controller : CatalogController<TABLE8008Dto, CreateTABLE8008Dto, UpdateTABLE8008Dto, int>
{
    public TABLE8008Controller(ITABLE8008Service service)
        : base(service, "TABLE8008", "NORIGINS", new[] { "NORIGINS", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
