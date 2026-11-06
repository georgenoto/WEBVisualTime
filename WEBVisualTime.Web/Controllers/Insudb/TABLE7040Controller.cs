using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7040;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7040Controller : CatalogController<TABLE7040Dto, CreateTABLE7040Dto, UpdateTABLE7040Dto, int>
{
    public TABLE7040Controller(ITABLE7040Service service)
        : base(service, "TABLE7040", "NSPCOMBTYPE", new[] { "NSPCOMBTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
