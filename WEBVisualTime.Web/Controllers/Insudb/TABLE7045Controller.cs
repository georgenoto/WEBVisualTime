using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7045;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7045Controller : CatalogController<TABLE7045Dto, CreateTABLE7045Dto, UpdateTABLE7045Dto, int>
{
    public TABLE7045Controller(ITABLE7045Service service)
        : base(service, "TABLE7045", "NACTIVITYTYPE", new[] { "NACTIVITYTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
