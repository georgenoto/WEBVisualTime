using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5520;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5520Controller : CrudApiController<TABLE5520Dto, CreateTABLE5520Dto, UpdateTABLE5520Dto, int>
{
    public TABLE5520Controller(ITABLE5520Service service) : base(service, dto => dto.NTYPEINVEST) { }
}
