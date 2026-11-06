using WEBVisualTime.Servicios.Insudb.DTOs.TABLE165;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE165Controller : CrudApiController<TABLE165Dto, CreateTABLE165Dto, UpdateTABLE165Dto, int>
{
    public TABLE165Controller(ITABLE165Service service) : base(service, dto => dto.NTYPE_HIST) { }
}
