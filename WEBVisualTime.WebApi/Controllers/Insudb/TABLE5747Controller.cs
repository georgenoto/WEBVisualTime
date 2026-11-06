using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5747;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5747Controller : CrudApiController<TABLE5747Dto, CreateTABLE5747Dto, UpdateTABLE5747Dto, int>
{
    public TABLE5747Controller(ITABLE5747Service service) : base(service, dto => dto.NTYPE_SPAY) { }
}
