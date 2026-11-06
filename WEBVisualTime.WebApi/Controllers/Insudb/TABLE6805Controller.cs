using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6805;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6805Controller : CrudApiController<TABLE6805Dto, CreateTABLE6805Dto, UpdateTABLE6805Dto, int>
{
    public TABLE6805Controller(ITABLE6805Service service) : base(service, dto => dto.NDATATYPE) { }
}
