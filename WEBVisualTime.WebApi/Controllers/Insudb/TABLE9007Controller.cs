using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9007;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9007Controller : CrudApiController<TABLE9007Dto, CreateTABLE9007Dto, UpdateTABLE9007Dto, int>
{
    public TABLE9007Controller(ITABLE9007Service service) : base(service, dto => dto.NMACHINECODE) { }
}
