using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6072;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6072Controller : CrudApiController<TABLE6072Dto, CreateTABLE6072Dto, UpdateTABLE6072Dto, int>
{
    public TABLE6072Controller(ITABLE6072Service service) : base(service, dto => dto.NIDCATAS) { }
}
