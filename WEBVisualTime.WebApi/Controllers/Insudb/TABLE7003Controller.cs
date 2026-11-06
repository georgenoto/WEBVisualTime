using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7003;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7003Controller : CrudApiController<TABLE7003Dto, CreateTABLE7003Dto, UpdateTABLE7003Dto, int>
{
    public TABLE7003Controller(ITABLE7003Service service) : base(service, dto => dto.NROLEREQUEST) { }
}
