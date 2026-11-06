using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9Controller : CrudApiController<TABLE9Dto, CreateTABLE9Dto, UpdateTABLE9Dto, int>
{
    public TABLE9Controller(ITABLE9Service service) : base(service, dto => dto.NOFFICE) { }
}
