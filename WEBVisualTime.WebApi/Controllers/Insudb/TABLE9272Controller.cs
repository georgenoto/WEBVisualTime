using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9272;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9272Controller : CrudApiController<TABLE9272Dto, CreateTABLE9272Dto, UpdateTABLE9272Dto, int>
{
    public TABLE9272Controller(ITABLE9272Service service) : base(service, dto => dto.NACCCRITERION) { }
}
