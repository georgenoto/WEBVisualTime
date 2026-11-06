using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5570;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5570Controller : CrudApiController<TABLE5570Dto, CreateTABLE5570Dto, UpdateTABLE5570Dto, int>
{
    public TABLE5570Controller(ITABLE5570Service service) : base(service, dto => dto.NTYPESUPPORT) { }
}
