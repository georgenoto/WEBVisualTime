using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7204;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7204Controller : CrudApiController<TABLE7204Dto, CreateTABLE7204Dto, UpdateTABLE7204Dto, long>
{
    public TABLE7204Controller(ITABLE7204Service service) : base(service, dto => dto.NCODIGINT) { }
}
