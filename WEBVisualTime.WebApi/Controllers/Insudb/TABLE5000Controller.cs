using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5000Controller : CrudApiController<TABLE5000Dto, CreateTABLE5000Dto, UpdateTABLE5000Dto, int>
{
    public TABLE5000Controller(ITABLE5000Service service) : base(service, dto => dto.NBRANCH_REI) { }
}
