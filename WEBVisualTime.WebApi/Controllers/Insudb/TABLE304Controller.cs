using WEBVisualTime.Servicios.Insudb.DTOs.TABLE304;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE304Controller : CrudApiController<TABLE304Dto, CreateTABLE304Dto, UpdateTABLE304Dto, long>
{
    public TABLE304Controller(ITABLE304Service service) : base(service, dto => dto.NCODIGINT) { }
}
