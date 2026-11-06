using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5621;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5621Controller : CrudApiController<TABLE5621Dto, CreateTABLE5621Dto, UpdateTABLE5621Dto, int>
{
    public TABLE5621Controller(ITABLE5621Service service) : base(service, dto => dto.NTODAYSDEPOSIT) { }
}
