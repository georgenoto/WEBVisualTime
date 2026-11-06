using WEBVisualTime.Servicios.Insudb.DTOs.TABLE52;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE52Controller : CrudApiController<TABLE52Dto, CreateTABLE52Dto, UpdateTABLE52Dto, string>
{
    public TABLE52Controller(ITABLE52Service service) : base(service, dto => dto.SCAREN_TYPE) { }
}
