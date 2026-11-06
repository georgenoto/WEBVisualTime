using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5636;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5636Controller : CrudApiController<TABLE5636Dto, CreateTABLE5636Dto, UpdateTABLE5636Dto, int>
{
    public TABLE5636Controller(ITABLE5636Service service) : base(service, dto => dto.NTYPE_PAYMENT) { }
}
