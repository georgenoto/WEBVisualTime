using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5701;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5701Controller : CrudApiController<TABLE5701Dto, CreateTABLE5701Dto, UpdateTABLE5701Dto, int>
{
    public TABLE5701Controller(ITABLE5701Service service) : base(service, dto => dto.NFORMAT) { }
}
