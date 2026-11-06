using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9208;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9208Controller : CatalogController<TABLE9208Dto, CreateTABLE9208Dto, UpdateTABLE9208Dto, int>
{
    public TABLE9208Controller(ITABLE9208Service service)
        : base(service, "TABLE9208", "NTYPEXP", new[] { "NTYPEXP", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
