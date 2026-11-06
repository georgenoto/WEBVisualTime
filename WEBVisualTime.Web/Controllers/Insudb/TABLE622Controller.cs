using WEBVisualTime.Servicios.Insudb.DTOs.TABLE622;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE622Controller : CatalogController<TABLE622Dto, CreateTABLE622Dto, UpdateTABLE622Dto, int>
{
    public TABLE622Controller(ITABLE622Service service)
        : base(service, "TABLE622", "NPARAMETERS", new[] { "NPARAMETERS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
