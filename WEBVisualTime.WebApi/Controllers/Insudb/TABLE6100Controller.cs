using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6100;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6100Controller : CrudApiController<TABLE6100Dto, CreateTABLE6100Dto, UpdateTABLE6100Dto, int>
{
    public TABLE6100Controller(ITABLE6100Service service) : base(service, dto => dto.NCLASEMPRESALEGAL) { }
}
