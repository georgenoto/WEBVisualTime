using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6000;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6000Controller : CrudApiController<TABLE6000Dto, CreateTABLE6000Dto, UpdateTABLE6000Dto, int>
{
    public TABLE6000Controller(ITABLE6000Service service) : base(service, dto => dto.NTYPEOFADDRESS) { }
}
