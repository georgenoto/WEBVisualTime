using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5577;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5577Controller : CrudApiController<TABLE5577Dto, CreateTABLE5577Dto, UpdateTABLE5577Dto, int>
{
    public TABLE5577Controller(ITABLE5577Service service) : base(service, dto => dto.NCHEOPER_REASON) { }
}
