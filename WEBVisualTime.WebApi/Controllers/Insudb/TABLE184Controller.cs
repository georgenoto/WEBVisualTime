using WEBVisualTime.Servicios.Insudb.DTOs.TABLE184;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE184Controller : CrudApiController<TABLE184Dto, CreateTABLE184Dto, UpdateTABLE184Dto, int>
{
    public TABLE184Controller(ITABLE184Service service) : base(service, dto => dto.NBENE_TYPE) { }
}
