using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9274;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9274Controller : CrudApiController<TABLE9274Dto, CreateTABLE9274Dto, UpdateTABLE9274Dto, int>
{
    public TABLE9274Controller(ITABLE9274Service service) : base(service, dto => dto.NNULLCODE) { }
}
