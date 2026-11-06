using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9280;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9280Controller : CatalogController<TABLE9280Dto, CreateTABLE9280Dto, UpdateTABLE9280Dto, int>
{
    public TABLE9280Controller(ITABLE9280Service service)
        : base(service, "TABLE9280", "NCOINS_TYPE", new[] { "NCOINS_TYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
