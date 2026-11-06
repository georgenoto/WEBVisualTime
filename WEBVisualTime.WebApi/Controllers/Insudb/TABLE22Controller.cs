using WEBVisualTime.Servicios.Insudb.DTOs.TABLE22;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE22Controller : CrudApiController<TABLE22Dto, CreateTABLE22Dto, UpdateTABLE22Dto, int>
{
    public TABLE22Controller(ITABLE22Service service) : base(service, dto => dto.NCONCEPT) { }
}
