using WEBVisualTime.Servicios.Insudb.DTOs.TABLE297;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE297Controller : CrudApiController<TABLE297Dto, CreateTABLE297Dto, UpdateTABLE297Dto, long>
{
    public TABLE297Controller(ITABLE297Service service) : base(service, dto => dto.NCODIGINT) { }
}
