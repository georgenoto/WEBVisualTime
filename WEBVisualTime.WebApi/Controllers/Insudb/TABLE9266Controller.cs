using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9266;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9266Controller : CrudApiController<TABLE9266Dto, CreateTABLE9266Dto, UpdateTABLE9266Dto, int>
{
    public TABLE9266Controller(ITABLE9266Service service) : base(service, dto => dto.NMOVEMENT_TYPE) { }
}
