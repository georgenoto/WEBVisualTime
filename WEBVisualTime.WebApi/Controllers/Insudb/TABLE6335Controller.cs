using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6335;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6335Controller : CrudApiController<TABLE6335Dto, CreateTABLE6335Dto, UpdateTABLE6335Dto, int>
{
    public TABLE6335Controller(ITABLE6335Service service) : base(service, dto => dto.NTYPPREMRECOG) { }
}
