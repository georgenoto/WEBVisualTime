using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5524;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5524Controller : CrudApiController<TABLE5524Dto, CreateTABLE5524Dto, UpdateTABLE5524Dto, long>
{
    public TABLE5524Controller(ITABLE5524Service service) : base(service, dto => dto.NAFP) { }
}
