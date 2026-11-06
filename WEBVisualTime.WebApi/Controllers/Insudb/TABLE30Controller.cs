using WEBVisualTime.Servicios.Insudb.DTOs.TABLE30;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE30Controller : CrudApiController<TABLE30Dto, CreateTABLE30Dto, UpdateTABLE30Dto, string>
{
    public TABLE30Controller(ITABLE30Service service) : base(service, dto => dto.SDISEXPRI) { }
}
