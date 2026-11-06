using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7046;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7046Controller : CatalogController<TABLE7046Dto, CreateTABLE7046Dto, UpdateTABLE7046Dto, int>
{
    public TABLE7046Controller(ITABLE7046Service service)
        : base(service, "TABLE7046", "NFAMILY", new[] { "NFAMILY", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
