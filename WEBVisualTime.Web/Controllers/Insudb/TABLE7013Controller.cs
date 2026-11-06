using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7013;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7013Controller : CatalogController<TABLE7013Dto, CreateTABLE7013Dto, UpdateTABLE7013Dto, long>
{
    public TABLE7013Controller(ITABLE7013Service service)
        : base(service, "TABLE7013", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
