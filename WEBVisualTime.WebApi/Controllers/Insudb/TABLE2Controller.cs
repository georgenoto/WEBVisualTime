using WEBVisualTime.Servicios.Insudb.DTOs.TABLE2;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE2Controller : CrudApiController<TABLE2Dto, CreateTABLE2Dto, UpdateTABLE2Dto, long>
{
    public TABLE2Controller(ITABLE2Service service) : base(service, dto => dto.NCODIGINT) { }
}
