using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7043;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7043Controller : CatalogController<TABLE7043Dto, CreateTABLE7043Dto, UpdateTABLE7043Dto, long>
{
    public TABLE7043Controller(ITABLE7043Service service)
        : base(service, "TABLE7043", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
