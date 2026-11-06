using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5539;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5539Controller : CrudApiController<TABLE5539Dto, CreateTABLE5539Dto, UpdateTABLE5539Dto, int>
{
    public TABLE5539Controller(ITABLE5539Service service) : base(service, dto => dto.NINSTRUMENT_TY) { }
}
