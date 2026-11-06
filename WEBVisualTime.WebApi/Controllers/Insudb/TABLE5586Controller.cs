using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5586;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5586Controller : CrudApiController<TABLE5586Dto, CreateTABLE5586Dto, UpdateTABLE5586Dto, int>
{
    public TABLE5586Controller(ITABLE5586Service service) : base(service, dto => dto.NDEFERRED) { }
}
