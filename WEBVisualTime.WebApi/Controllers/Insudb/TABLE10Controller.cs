using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE10Controller : CrudApiController<TABLE10Dto, CreateTABLE10Dto, UpdateTABLE10Dto, int>
{
    public TABLE10Controller(ITABLE10Service service) : base(service, dto => dto.NBRANCH) { }
}
