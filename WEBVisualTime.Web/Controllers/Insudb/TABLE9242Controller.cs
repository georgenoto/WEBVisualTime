using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9242;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9242Controller : CatalogController<TABLE9242Dto, CreateTABLE9242Dto, UpdateTABLE9242Dto, int>
{
    public TABLE9242Controller(ITABLE9242Service service)
        : base(service, "TABLE9242", "NTYPEDOC_PAY", new[] { "NTYPEDOC_PAY", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
