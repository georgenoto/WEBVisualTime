using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5616;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5616Controller : CrudApiController<TABLE5616Dto, CreateTABLE5616Dto, UpdateTABLE5616Dto, int>
{
    public TABLE5616Controller(ITABLE5616Service service) : base(service, dto => dto.NPAYFORMCREDITCARD) { }
}
