using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7003;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7003Controller : CatalogController<TABLE7003Dto, CreateTABLE7003Dto, UpdateTABLE7003Dto, int>
{
    public TABLE7003Controller(ITABLE7003Service service)
        : base(service, "TABLE7003", "NROLEREQUEST", new[] { "NROLEREQUEST", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
