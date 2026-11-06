using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5635;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5635Controller : CrudApiController<TABLE5635Dto, CreateTABLE5635Dto, UpdateTABLE5635Dto, int>
{
    public TABLE5635Controller(ITABLE5635Service service) : base(service, dto => dto.NSURR_REASON) { }
}
