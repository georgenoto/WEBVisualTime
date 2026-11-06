using WEBVisualTime.Servicios.Insudb.DTOs.TABLE285;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE285Controller : CatalogController<TABLE285Dto, CreateTABLE285Dto, UpdateTABLE285Dto, long>
{
    public TABLE285Controller(ITABLE285Service service)
        : base(service, "TABLE285", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
