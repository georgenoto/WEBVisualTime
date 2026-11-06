using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5588;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5588Controller : CrudApiController<TABLE5588Dto, CreateTABLE5588Dto, UpdateTABLE5588Dto, int>
{
    public TABLE5588Controller(ITABLE5588Service service) : base(service, dto => dto.NTRATYPEP) { }
}
