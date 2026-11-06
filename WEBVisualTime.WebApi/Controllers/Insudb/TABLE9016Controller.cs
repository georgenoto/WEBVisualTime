using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9016;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9016Controller : CrudApiController<TABLE9016Dto, CreateTABLE9016Dto, UpdateTABLE9016Dto, int>
{
    public TABLE9016Controller(ITABLE9016Service service) : base(service, dto => dto.NREFBANK) { }
}
