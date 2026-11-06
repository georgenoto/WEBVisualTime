using WEBVisualTime.Servicios.Insudb.DTOs.TAB_DENTITION;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TAB_DENTITIONController : CrudApiController<TAB_DENTITIONDto, CreateTAB_DENTITIONDto, UpdateTAB_DENTITIONDto, int>
{
    public TAB_DENTITIONController(ITAB_DENTITIONService service) : base(service, dto => dto.NIDDENTITION) { }
}
