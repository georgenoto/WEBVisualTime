using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5572;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5572Controller : CrudApiController<TABLE5572Dto, CreateTABLE5572Dto, UpdateTABLE5572Dto, int>
{
    public TABLE5572Controller(ITABLE5572Service service) : base(service, dto => dto.NSTATUS_EVAL) { }
}
