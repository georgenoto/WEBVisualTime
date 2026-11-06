using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8605;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8605Controller : CatalogController<TABLE8605Dto, CreateTABLE8605Dto, UpdateTABLE8605Dto, string>
{
    public TABLE8605Controller(ITABLE8605Service service)
        : base(service, "TABLE8605", "SCARECLASS", new[] { "SCARECLASS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
