using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5521;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5521Controller : CrudApiController<TABLE5521Dto, CreateTABLE5521Dto, UpdateTABLE5521Dto, int>
{
    public TABLE5521Controller(ITABLE5521Service service) : base(service, dto => dto.NLIMITDRIV) { }
}
