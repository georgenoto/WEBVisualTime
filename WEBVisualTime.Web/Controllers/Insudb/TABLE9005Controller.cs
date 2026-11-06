using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9005;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9005Controller : CatalogController<TABLE9005Dto, CreateTABLE9005Dto, UpdateTABLE9005Dto, int>
{
    public TABLE9005Controller(ITABLE9005Service service)
        : base(service, "TABLE9005", "NBUSINESSTY", new[] { "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE", "NBUSINESSTY" }) { }
}
