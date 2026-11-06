using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7007;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7007Controller : CatalogController<TABLE7007Dto, CreateTABLE7007Dto, UpdateTABLE7007Dto, long>
{
    public TABLE7007Controller(ITABLE7007Service service)
        : base(service, "TABLE7007", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
