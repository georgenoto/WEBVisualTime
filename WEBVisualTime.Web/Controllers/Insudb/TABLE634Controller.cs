using WEBVisualTime.Servicios.Insudb.DTOs.TABLE634;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE634Controller : CatalogController<TABLE634Dto, CreateTABLE634Dto, UpdateTABLE634Dto, int>
{
    public TABLE634Controller(ITABLE634Service service)
        : base(service, "TABLE634", "NBRANCH_GEN", new[] { "NBRANCH_GEN", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
