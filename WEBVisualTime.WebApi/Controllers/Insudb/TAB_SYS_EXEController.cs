using WEBVisualTime.Servicios.Insudb.DTOs.TAB_SYS_EXE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TAB_SYS_EXEController : CrudApiController<TAB_SYS_EXEDto, CreateTAB_SYS_EXEDto, UpdateTAB_SYS_EXEDto, int>
{
    public TAB_SYS_EXEController(ITAB_SYS_EXEService service) : base(service, dto => dto.NEXE_CODE) { }
}
