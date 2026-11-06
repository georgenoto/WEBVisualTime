using WEBVisualTime.Servicios.Insudb.DTOs.TAB_GOALS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TAB_GOALSController : CrudApiController<TAB_GOALSDto, CreateTAB_GOALSDto, UpdateTAB_GOALSDto, int>
{
    public TAB_GOALSController(ITAB_GOALSService service) : base(service, dto => dto.NCODE) { }
}
