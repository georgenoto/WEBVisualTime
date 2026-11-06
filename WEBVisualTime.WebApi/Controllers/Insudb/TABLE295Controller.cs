using WEBVisualTime.Servicios.Insudb.DTOs.TABLE295;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE295Controller : CrudApiController<TABLE295Dto, CreateTABLE295Dto, UpdateTABLE295Dto, int>
{
    public TABLE295Controller(ITABLE295Service service) : base(service, dto => dto.NNULLCODE) { }
}
