using WEBVisualTime.Servicios.Insudb.DTOs.TABLE308;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE308Controller : CrudApiController<TABLE308Dto, CreateTABLE308Dto, UpdateTABLE308Dto, long>
{
    public TABLE308Controller(ITABLE308Service service) : base(service, dto => dto.NCODIGINT) { }
}
