using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7006;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7006Controller : CatalogController<TABLE7006Dto, CreateTABLE7006Dto, UpdateTABLE7006Dto, long>
{
    public TABLE7006Controller(ITABLE7006Service service)
        : base(service, "TABLE7006", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
