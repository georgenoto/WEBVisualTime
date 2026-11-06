using WEBVisualTime.Servicios.Insudb.DTOs.TABLE294;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE294Controller : CrudApiController<TABLE294Dto, CreateTABLE294Dto, UpdateTABLE294Dto, int>
{
    public TABLE294Controller(ITABLE294Service service) : base(service, dto => dto.NEFFCLAMO) { }
}
