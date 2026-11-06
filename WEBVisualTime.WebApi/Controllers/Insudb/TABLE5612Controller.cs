using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5612;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5612Controller : CrudApiController<TABLE5612Dto, CreateTABLE5612Dto, UpdateTABLE5612Dto, int>
{
    public TABLE5612Controller(ITABLE5612Service service) : base(service, dto => dto.NDAMAGE) { }
}
