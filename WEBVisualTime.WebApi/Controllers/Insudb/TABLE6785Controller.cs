using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6785;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6785Controller : CrudApiController<TABLE6785Dto, CreateTABLE6785Dto, UpdateTABLE6785Dto, int>
{
    public TABLE6785Controller(ITABLE6785Service service) : base(service, dto => dto.NRISKTYPE) { }
}
