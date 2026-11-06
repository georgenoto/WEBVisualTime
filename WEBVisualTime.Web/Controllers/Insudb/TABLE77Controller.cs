using WEBVisualTime.Servicios.Insudb.DTOs.TABLE77;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE77Controller : CatalogController<TABLE77Dto, CreateTABLE77Dto, UpdateTABLE77Dto, int>
{
    public TABLE77Controller(ITABLE77Service service)
        : base(service, "TABLE77", "NCAUSE_AMEN", new[] { "NCAUSE_AMEN", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
