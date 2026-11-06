using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8601;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8601Controller : CrudApiController<TABLE8601Dto, CreateTABLE8601Dto, UpdateTABLE8601Dto, string>
{
    public TABLE8601Controller(ITABLE8601Service service) : base(service, dto => dto.SBENEFITCLAS) { }
}
