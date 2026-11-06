using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6022;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6022Controller : CrudApiController<TABLE6022Dto, CreateTABLE6022Dto, UpdateTABLE6022Dto, int>
{
    public TABLE6022Controller(ITABLE6022Service service) : base(service, dto => dto.NSOATCLASS) { }
}
