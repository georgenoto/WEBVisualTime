using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5566;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5566Controller : CrudApiController<TABLE5566Dto, CreateTABLE5566Dto, UpdateTABLE5566Dto, int>
{
    public TABLE5566Controller(ITABLE5566Service service) : base(service, dto => dto.NSUS_REASON) { }
}
