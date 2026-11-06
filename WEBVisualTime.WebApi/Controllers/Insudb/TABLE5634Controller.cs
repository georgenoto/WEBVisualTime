using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5634;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5634Controller : CrudApiController<TABLE5634Dto, CreateTABLE5634Dto, UpdateTABLE5634Dto, int>
{
    public TABLE5634Controller(ITABLE5634Service service) : base(service, dto => dto.NTYPEINSTITU) { }
}
