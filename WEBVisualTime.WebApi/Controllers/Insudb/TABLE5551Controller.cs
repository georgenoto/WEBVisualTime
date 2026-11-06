using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5551;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5551Controller : CrudApiController<TABLE5551Dto, CreateTABLE5551Dto, UpdateTABLE5551Dto, int>
{
    public TABLE5551Controller(ITABLE5551Service service) : base(service, dto => dto.NCOLLECTORTYPE) { }
}
