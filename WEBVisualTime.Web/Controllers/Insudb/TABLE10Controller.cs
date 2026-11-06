using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE10Controller : CatalogController<TABLE10Dto, CreateTABLE10Dto, UpdateTABLE10Dto, int>
{
    public TABLE10Controller(ITABLE10Service service)
        : base(service, "TABLE10", "NBRANCH", new[] { "NBRANCH", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
