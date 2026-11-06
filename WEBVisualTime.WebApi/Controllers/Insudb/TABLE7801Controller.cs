using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7801;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7801Controller : CrudApiController<TABLE7801Dto, CreateTABLE7801Dto, UpdateTABLE7801Dto, int>
{
    public TABLE7801Controller(ITABLE7801Service service) : base(service, dto => dto.NPAYMENTADDRESS) { }
}
