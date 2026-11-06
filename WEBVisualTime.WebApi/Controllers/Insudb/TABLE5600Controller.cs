using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5600;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5600Controller : CrudApiController<TABLE5600Dto, CreateTABLE5600Dto, UpdateTABLE5600Dto, int>
{
    public TABLE5600Controller(ITABLE5600Service service) : base(service, dto => dto.NINDRECDEP) { }
}
