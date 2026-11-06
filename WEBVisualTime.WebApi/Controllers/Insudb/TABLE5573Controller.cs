using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5573;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5573Controller : CrudApiController<TABLE5573Dto, CreateTABLE5573Dto, UpdateTABLE5573Dto, int>
{
    public TABLE5573Controller(ITABLE5573Service service) : base(service, dto => dto.NOBSERVATION) { }
}
