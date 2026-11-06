using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7001;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7001Controller : CatalogController<TABLE7001Dto, CreateTABLE7001Dto, UpdateTABLE7001Dto, int>
{
    public TABLE7001Controller(ITABLE7001Service service)
        : base(service, "TABLE7001", "NTYPEREQUEST", new[] { "NTYPEREQUEST", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
