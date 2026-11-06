using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5001Controller : CrudApiController<TABLE5001Dto, CreateTABLE5001Dto, UpdateTABLE5001Dto, int>
{
    public TABLE5001Controller(ITABLE5001Service service) : base(service, dto => dto.NINSUR_AREA) { }
}
