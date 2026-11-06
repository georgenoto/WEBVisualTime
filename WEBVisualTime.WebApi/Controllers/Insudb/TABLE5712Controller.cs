using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5712;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5712Controller : CrudApiController<TABLE5712Dto, CreateTABLE5712Dto, UpdateTABLE5712Dto, int>
{
    public TABLE5712Controller(ITABLE5712Service service) : base(service, dto => dto.NCAUSE) { }
}
