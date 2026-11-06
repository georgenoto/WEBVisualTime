using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5561;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5561Controller : CrudApiController<TABLE5561Dto, CreateTABLE5561Dto, UpdateTABLE5561Dto, int>
{
    public TABLE5561Controller(ITABLE5561Service service) : base(service, dto => dto.NSTATUSROL) { }
}
