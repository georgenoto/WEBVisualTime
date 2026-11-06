using WEBVisualTime.Servicios.Insudb.DTOs.TABLE221;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE221Controller : CatalogController<TABLE221Dto, CreateTABLE221Dto, UpdateTABLE221Dto, long>
{
    public TABLE221Controller(ITABLE221Service service)
        : base(service, "TABLE221", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
