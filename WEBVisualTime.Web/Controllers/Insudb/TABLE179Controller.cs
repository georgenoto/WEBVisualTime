using WEBVisualTime.Servicios.Insudb.DTOs.TABLE179;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE179Controller : CatalogController<TABLE179Dto, CreateTABLE179Dto, UpdateTABLE179Dto, int>
{
    public TABLE179Controller(ITABLE179Service service)
        : base(service, "TABLE179", "NTYPECASH", new[] { "NTYPECASH", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
