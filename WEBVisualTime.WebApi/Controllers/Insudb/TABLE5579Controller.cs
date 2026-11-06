using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5579;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5579Controller : CrudApiController<TABLE5579Dto, CreateTABLE5579Dto, UpdateTABLE5579Dto, int>
{
    public TABLE5579Controller(ITABLE5579Service service) : base(service, dto => dto.NAUTO_PART) { }
}
