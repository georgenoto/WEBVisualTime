using WEBVisualTime.Servicios.Insudb.DTOs.TABLE400;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE400Controller : CrudApiController<TABLE400Dto, CreateTABLE400Dto, UpdateTABLE400Dto, int>
{
    public TABLE400Controller(ITABLE400Service service) : base(service, dto => dto.NTYP_ACCO) { }
}
