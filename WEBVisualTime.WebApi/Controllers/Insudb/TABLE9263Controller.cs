using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9263;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9263Controller : CrudApiController<TABLE9263Dto, CreateTABLE9263Dto, UpdateTABLE9263Dto, int>
{
    public TABLE9263Controller(ITABLE9263Service service) : base(service, dto => dto.NNULLCODE) { }
}
