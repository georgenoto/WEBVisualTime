using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7037;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7037Controller : CrudApiController<TABLE7037Dto, CreateTABLE7037Dto, UpdateTABLE7037Dto, int>
{
    public TABLE7037Controller(ITABLE7037Service service) : base(service, dto => dto.NSIDECLOSETYPE) { }
}
