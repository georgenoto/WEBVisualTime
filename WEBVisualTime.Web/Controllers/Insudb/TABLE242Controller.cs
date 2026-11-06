using WEBVisualTime.Servicios.Insudb.DTOs.TABLE242;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE242Controller : CatalogController<TABLE242Dto, CreateTABLE242Dto, UpdateTABLE242Dto, int>
{
    public TABLE242Controller(ITABLE242Service service)
        : base(service, "TABLE242", "NUNIT_TYPE", new[] { "NUNIT_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
