using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9013;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9013Controller : CrudApiController<TABLE9013Dto, CreateTABLE9013Dto, UpdateTABLE9013Dto, int>
{
    public TABLE9013Controller(ITABLE9013Service service) : base(service, dto => dto.NTYPEPRODUCT) { }
}
