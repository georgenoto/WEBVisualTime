using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9232;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9232Controller : CrudApiController<TABLE9232Dto, CreateTABLE9232Dto, UpdateTABLE9232Dto, int>
{
    public TABLE9232Controller(ITABLE9232Service service) : base(service, dto => dto.NTYPE_EV_ENDOR) { }
}
