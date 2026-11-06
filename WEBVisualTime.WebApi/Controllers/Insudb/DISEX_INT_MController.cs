using WEBVisualTime.Servicios.Insudb.DTOs.DISEX_INT_M;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class DISEX_INT_MController : CrudApiController<DISEX_INT_MDto, CreateDISEX_INT_MDto, UpdateDISEX_INT_MDto, int>
{
    public DISEX_INT_MController(IDISEX_INT_MService service) : base(service, dto => dto.NECO_SCHE) { }
}
