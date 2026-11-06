using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9245;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9245Controller : CrudApiController<TABLE9245Dto, CreateTABLE9245Dto, UpdateTABLE9245Dto, int>
{
    public TABLE9245Controller(ITABLE9245Service service) : base(service, dto => dto.NACTIONTYPE) { }
}
