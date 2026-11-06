using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5519;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5519Controller : CrudApiController<TABLE5519Dto, CreateTABLE5519Dto, UpdateTABLE5519Dto, int>
{
    public TABLE5519Controller(ITABLE5519Service service) : base(service, dto => dto.NOPTION) { }
}
