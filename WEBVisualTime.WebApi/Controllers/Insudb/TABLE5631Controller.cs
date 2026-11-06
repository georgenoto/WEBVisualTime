using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5631;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5631Controller : CrudApiController<TABLE5631Dto, CreateTABLE5631Dto, UpdateTABLE5631Dto, int>
{
    public TABLE5631Controller(ITABLE5631Service service) : base(service, dto => dto.NCAUSE) { }
}
