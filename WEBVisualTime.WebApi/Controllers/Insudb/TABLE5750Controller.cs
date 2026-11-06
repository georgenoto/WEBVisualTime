using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5750;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5750Controller : CrudApiController<TABLE5750Dto, CreateTABLE5750Dto, UpdateTABLE5750Dto, string>
{
    public TABLE5750Controller(ITABLE5750Service service) : base(service, dto => dto.STYPECOM) { }
}
