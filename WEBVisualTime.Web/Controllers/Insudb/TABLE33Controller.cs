using WEBVisualTime.Servicios.Insudb.DTOs.TABLE33;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE33Controller : CatalogController<TABLE33Dto, CreateTABLE33Dto, UpdateTABLE33Dto, string>
{
    public TABLE33Controller(ITABLE33Service service)
        : base(service, "TABLE33", "SFRANCAPL", new[] { "SFRANCAPL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
