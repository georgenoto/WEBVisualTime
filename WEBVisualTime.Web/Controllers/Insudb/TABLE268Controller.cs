using WEBVisualTime.Servicios.Insudb.DTOs.TABLE268;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE268Controller : CatalogController<TABLE268Dto, CreateTABLE268Dto, UpdateTABLE268Dto, int>
{
    public TABLE268Controller(ITABLE268Service service)
        : base(service, "TABLE268", "NGROUP_COMP", new[] { "NGROUP_COMP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
