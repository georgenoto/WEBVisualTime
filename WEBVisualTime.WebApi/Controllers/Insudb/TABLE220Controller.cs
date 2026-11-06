using WEBVisualTime.Servicios.Insudb.DTOs.TABLE220;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE220Controller : CrudApiController<TABLE220Dto, CreateTABLE220Dto, UpdateTABLE220Dto, int>
{
    public TABLE220Controller(ITABLE220Service service) : base(service, dto => dto.NVESTATUS) { }
}
