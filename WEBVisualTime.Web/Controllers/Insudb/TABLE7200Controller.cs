using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7200;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7200Controller : CatalogController<TABLE7200Dto, CreateTABLE7200Dto, UpdateTABLE7200Dto, int>
{
    public TABLE7200Controller(ITABLE7200Service service)
        : base(service, "TABLE7200", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
