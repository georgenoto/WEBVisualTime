using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7801;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7801Controller : CatalogController<TABLE7801Dto, CreateTABLE7801Dto, UpdateTABLE7801Dto, int>
{
    public TABLE7801Controller(ITABLE7801Service service)
        : base(service, "TABLE7801", "NPAYMENTADDRESS", new[] { "NPAYMENTADDRESS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
