using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8600;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8600Controller : CatalogController<TABLE8600Dto, CreateTABLE8600Dto, UpdateTABLE8600Dto, string>
{
    public TABLE8600Controller(ITABLE8600Service service)
        : base(service, "TABLE8600", "STYPEBENEFIT", new[] { "STYPEBENEFIT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
