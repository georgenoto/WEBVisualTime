using WEBVisualTime.Servicios.Insudb.DTOs.TAB_SYS_EXE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_SYS_EXEController : CatalogController<TAB_SYS_EXEDto, CreateTAB_SYS_EXEDto, UpdateTAB_SYS_EXEDto, int>
{
    public TAB_SYS_EXEController(ITAB_SYS_EXEService service)
        : base(service, "TAB_SYS_EXE", "NEXE_CODE", new[] { "NEXE_CODE", "DCOMPDATE", "SEXE_NAME", "SDESCRIPT", "NUSERCODE", "SFOLDERNAME" }) { }
}
