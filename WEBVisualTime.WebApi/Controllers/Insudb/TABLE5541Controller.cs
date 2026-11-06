using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5541;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5541Controller : CrudApiController<TABLE5541Dto, CreateTABLE5541Dto, UpdateTABLE5541Dto, int>
{
    public TABLE5541Controller(ITABLE5541Service service) : base(service, dto => dto.NLEVEL_SECTOR) { }
}
