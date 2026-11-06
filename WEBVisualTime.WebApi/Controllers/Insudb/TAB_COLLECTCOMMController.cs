using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COLLECTCOMM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TAB_COLLECTCOMMController : CrudApiController<TAB_COLLECTCOMMDto, CreateTAB_COLLECTCOMMDto, UpdateTAB_COLLECTCOMMDto, int>
{
    public TAB_COLLECTCOMMController(ITAB_COLLECTCOMMService service) : base(service, dto => dto.NCODE) { }
}
