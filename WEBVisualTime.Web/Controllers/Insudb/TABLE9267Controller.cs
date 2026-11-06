using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9267;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9267Controller : CatalogController<TABLE9267Dto, CreateTABLE9267Dto, UpdateTABLE9267Dto, int>
{
    public TABLE9267Controller(ITABLE9267Service service)
        : base(service, "TABLE9267", "NOPERTYPE", new[] { "NOPERTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
