using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5602;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5602Controller : CrudApiController<TABLE5602Dto, CreateTABLE5602Dto, UpdateTABLE5602Dto, string>
{
    public TABLE5602Controller(ITABLE5602Service service) : base(service, dto => dto.STYPETAX) { }
}
