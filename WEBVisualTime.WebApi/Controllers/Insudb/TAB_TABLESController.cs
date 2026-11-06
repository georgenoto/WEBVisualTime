using WEBVisualTime.Servicios.Insudb.DTOs.TAB_TABLES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TAB_TABLESController : CrudApiController<TAB_TABLESDto, CreateTAB_TABLESDto, UpdateTAB_TABLESDto, string>
{
    public TAB_TABLESController(ITAB_TABLESService service) : base(service, dto => dto.STAB_CODE) { }
}
