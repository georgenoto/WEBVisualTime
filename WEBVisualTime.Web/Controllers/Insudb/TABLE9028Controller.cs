using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9028;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9028Controller : CatalogController<TABLE9028Dto, CreateTABLE9028Dto, UpdateTABLE9028Dto, int>
{
    public TABLE9028Controller(ITABLE9028Service service)
        : base(service, "TABLE9028", "NFINANCIAL", new[] { "NFINANCIAL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
