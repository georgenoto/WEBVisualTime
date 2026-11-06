using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9214;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9214Controller : CrudApiController<TABLE9214Dto, CreateTABLE9214Dto, UpdateTABLE9214Dto, int>
{
    public TABLE9214Controller(ITABLE9214Service service) : base(service, dto => dto.NGEOGRAPHAREA) { }
}
