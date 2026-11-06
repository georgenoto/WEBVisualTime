using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7002;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7002Controller : CatalogController<TABLE7002Dto, CreateTABLE7002Dto, UpdateTABLE7002Dto, int>
{
    public TABLE7002Controller(ITABLE7002Service service)
        : base(service, "TABLE7002", "NRESPONSECODE", new[] { "NRESPONSECODE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
