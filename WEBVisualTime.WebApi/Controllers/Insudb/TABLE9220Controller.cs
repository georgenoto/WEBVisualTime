using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9220;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9220Controller : CrudApiController<TABLE9220Dto, CreateTABLE9220Dto, UpdateTABLE9220Dto, int>
{
    public TABLE9220Controller(ITABLE9220Service service) : base(service, dto => dto.NINDPRINT) { }
}
