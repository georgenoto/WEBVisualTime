using WEBVisualTime.Servicios.Insudb.DTOs.TABLE307;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE307Controller : CatalogController<TABLE307Dto, CreateTABLE307Dto, UpdateTABLE307Dto, long>
{
    public TABLE307Controller(ITABLE307Service service)
        : base(service, "TABLE307", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
