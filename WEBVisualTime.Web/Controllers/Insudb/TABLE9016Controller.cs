using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9016;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9016Controller : CatalogController<TABLE9016Dto, CreateTABLE9016Dto, UpdateTABLE9016Dto, int>
{
    public TABLE9016Controller(ITABLE9016Service service)
        : base(service, "TABLE9016", "NREFBANK", new[] { "NREFBANK", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
