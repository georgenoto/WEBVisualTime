using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5597;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5597Controller : CrudApiController<TABLE5597Dto, CreateTABLE5597Dto, UpdateTABLE5597Dto, int>
{
    public TABLE5597Controller(ITABLE5597Service service) : base(service, dto => dto.NORD_TYPECOST) { }
}
