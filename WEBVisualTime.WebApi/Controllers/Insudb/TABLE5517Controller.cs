using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5517;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5517Controller : CrudApiController<TABLE5517Dto, CreateTABLE5517Dto, UpdateTABLE5517Dto, int>
{
    public TABLE5517Controller(ITABLE5517Service service) : base(service, dto => dto.NTYPLOAN_MOV) { }
}
