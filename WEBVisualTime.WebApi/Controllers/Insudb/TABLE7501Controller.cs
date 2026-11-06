using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7501;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7501Controller : CrudApiController<TABLE7501Dto, CreateTABLE7501Dto, UpdateTABLE7501Dto, long>
{
    public TABLE7501Controller(ITABLE7501Service service) : base(service, dto => dto.NCODIGINT) { }
}
