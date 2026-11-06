using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7508;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7508Controller : CrudApiController<TABLE7508Dto, CreateTABLE7508Dto, UpdateTABLE7508Dto, int>
{
    public TABLE7508Controller(ITABLE7508Service service) : base(service, dto => dto.NDAMAGE_TYP) { }
}
