using WEBVisualTime.Servicios.Insudb.DTOs.TABLE15;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE15Controller : CrudApiController<TABLE15Dto, CreateTABLE15Dto, UpdateTABLE15Dto, int>
{
    public TABLE15Controller(ITABLE15Service service) : base(service, dto => dto.NRELASHIP) { }
}
