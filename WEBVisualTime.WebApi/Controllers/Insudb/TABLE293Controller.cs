using WEBVisualTime.Servicios.Insudb.DTOs.TABLE293;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE293Controller : CrudApiController<TABLE293Dto, CreateTABLE293Dto, UpdateTABLE293Dto, int>
{
    public TABLE293Controller(ITABLE293Service service) : base(service, dto => dto.NCONCEPT) { }
}
