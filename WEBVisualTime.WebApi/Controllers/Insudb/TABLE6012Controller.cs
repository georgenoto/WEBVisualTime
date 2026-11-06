using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6012;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6012Controller : CrudApiController<TABLE6012Dto, CreateTABLE6012Dto, UpdateTABLE6012Dto, int>
{
    public TABLE6012Controller(ITABLE6012Service service) : base(service, dto => dto.NDWELLINGTYPE) { }
}
