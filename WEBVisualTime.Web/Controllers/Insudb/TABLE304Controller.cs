using WEBVisualTime.Servicios.Insudb.DTOs.TABLE304;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE304Controller : CatalogController<TABLE304Dto, CreateTABLE304Dto, UpdateTABLE304Dto, long>
{
    public TABLE304Controller(ITABLE304Service service)
        : base(service, "TABLE304", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
