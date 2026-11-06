using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7205;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7205Controller : CrudApiController<TABLE7205Dto, CreateTABLE7205Dto, UpdateTABLE7205Dto, int>
{
    public TABLE7205Controller(ITABLE7205Service service) : base(service, dto => dto.NFI_POLICYTYPE) { }
}
