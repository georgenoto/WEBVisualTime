using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9224;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9224Controller : CrudApiController<TABLE9224Dto, CreateTABLE9224Dto, UpdateTABLE9224Dto, int>
{
    public TABLE9224Controller(ITABLE9224Service service) : base(service, dto => dto.NNULLCODE) { }
}
