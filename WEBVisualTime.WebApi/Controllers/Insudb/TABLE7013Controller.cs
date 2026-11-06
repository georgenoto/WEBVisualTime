using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7013;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7013Controller : CrudApiController<TABLE7013Dto, CreateTABLE7013Dto, UpdateTABLE7013Dto, long>
{
    public TABLE7013Controller(ITABLE7013Service service) : base(service, dto => dto.NCODIGINT) { }
}
