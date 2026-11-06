using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5811;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5811Controller : CrudApiController<TABLE5811Dto, CreateTABLE5811Dto, UpdateTABLE5811Dto, int>
{
    public TABLE5811Controller(ITABLE5811Service service) : base(service, dto => dto.NQAMENTACTION) { }
}
