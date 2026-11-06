using WEBVisualTime.Servicios.Insudb.DTOs.TABLE258;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE258Controller : CatalogController<TABLE258Dto, CreateTABLE258Dto, UpdateTABLE258Dto, long>
{
    public TABLE258Controller(ITABLE258Service service)
        : base(service, "TABLE258", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
