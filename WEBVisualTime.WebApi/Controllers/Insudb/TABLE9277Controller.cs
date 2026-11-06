using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9277;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9277Controller : CrudApiController<TABLE9277Dto, CreateTABLE9277Dto, UpdateTABLE9277Dto, int>
{
    public TABLE9277Controller(ITABLE9277Service service) : base(service, dto => dto.NNULLCODE) { }
}
