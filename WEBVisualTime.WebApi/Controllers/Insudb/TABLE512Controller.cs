using WEBVisualTime.Servicios.Insudb.DTOs.TABLE512;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE512Controller : CrudApiController<TABLE512Dto, CreateTABLE512Dto, UpdateTABLE512Dto, int>
{
    public TABLE512Controller(ITABLE512Service service) : base(service, dto => dto.NSPORT) { }
}
