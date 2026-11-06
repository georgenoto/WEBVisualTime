using WEBVisualTime.Servicios.Insudb.DTOs.TRACKING;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TRACKINGController : CrudApiController<TRACKINGDto, CreateTRACKINGDto, UpdateTRACKINGDto, int>
{
    public TRACKINGController(ITRACKINGService service) : base(service, dto => dto.ID) { }
}
