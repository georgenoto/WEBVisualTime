using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5608;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5608Controller : CrudApiController<TABLE5608Dto, CreateTABLE5608Dto, UpdateTABLE5608Dto, int>
{
    public TABLE5608Controller(ITABLE5608Service service) : base(service, dto => dto.NSOURCE) { }
}
