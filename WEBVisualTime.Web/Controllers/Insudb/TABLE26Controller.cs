using WEBVisualTime.Servicios.Insudb.DTOs.TABLE26;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE26Controller : CatalogController<TABLE26Dto, CreateTABLE26Dto, UpdateTABLE26Dto, long>
{
    public TABLE26Controller(ITABLE26Service service)
        : base(service, "TABLE26", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
