using WEBVisualTime.Servicios.Insudb.DTOs.TABLE160;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE160Controller : CatalogController<TABLE160Dto, CreateTABLE160Dto, UpdateTABLE160Dto, int>
{
    public TABLE160Controller(ITABLE160Service service)
        : base(service, "TABLE160", "NPAY_CONCEP", new[] { "NPAY_CONCEP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "NTABLE159" }) { }
}
