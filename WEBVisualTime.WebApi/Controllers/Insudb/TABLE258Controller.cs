using WEBVisualTime.Servicios.Insudb.DTOs.TABLE258;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE258Controller : CrudApiController<TABLE258Dto, CreateTABLE258Dto, UpdateTABLE258Dto, long>
{
    public TABLE258Controller(ITABLE258Service service) : base(service, dto => dto.NCODIGINT) { }
}
