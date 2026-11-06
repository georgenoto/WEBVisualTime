using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5542;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5542Controller : CrudApiController<TABLE5542Dto, CreateTABLE5542Dto, UpdateTABLE5542Dto, int>
{
    public TABLE5542Controller(ITABLE5542Service service) : base(service, dto => dto.NLOCK_TYPE) { }
}
