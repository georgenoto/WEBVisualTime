using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6007;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6007Controller : CrudApiController<TABLE6007Dto, CreateTABLE6007Dto, UpdateTABLE6007Dto, int>
{
    public TABLE6007Controller(ITABLE6007Service service) : base(service, dto => dto.NZONETYPE) { }
}
