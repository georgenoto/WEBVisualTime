using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7201;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7201Controller : CrudApiController<TABLE7201Dto, CreateTABLE7201Dto, UpdateTABLE7201Dto, int>
{
    public TABLE7201Controller(ITABLE7201Service service) : base(service, dto => dto.NCODIGINT) { }
}
