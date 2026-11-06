using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9050;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9050Controller : CrudApiController<TABLE9050Dto, CreateTABLE9050Dto, UpdateTABLE9050Dto, int>
{
    public TABLE9050Controller(ITABLE9050Service service) : base(service, dto => dto.NFORMPAY) { }
}
