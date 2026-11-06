using WEBVisualTime.Servicios.Insudb.DTOs.TABLE312;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE312Controller : CrudApiController<TABLE312Dto, CreateTABLE312Dto, UpdateTABLE312Dto, int>
{
    public TABLE312Controller(ITABLE312Service service) : base(service, dto => dto.NLINK) { }
}
