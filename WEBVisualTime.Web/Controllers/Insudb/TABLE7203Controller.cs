using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7203;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7203Controller : CatalogController<TABLE7203Dto, CreateTABLE7203Dto, UpdateTABLE7203Dto, long>
{
    public TABLE7203Controller(ITABLE7203Service service)
        : base(service, "TABLE7203", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
