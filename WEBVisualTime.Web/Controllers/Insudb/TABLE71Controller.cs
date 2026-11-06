using WEBVisualTime.Servicios.Insudb.DTOs.TABLE71;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE71Controller : CatalogController<TABLE71Dto, CreateTABLE71Dto, UpdateTABLE71Dto, int>
{
    public TABLE71Controller(ITABLE71Service service)
        : base(service, "TABLE71", "NBRANCH_EST", new[] { "NBRANCH_EST", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
