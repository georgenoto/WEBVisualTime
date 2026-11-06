using WEBVisualTime.Servicios.Insudb.DTOs.TABLE124;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE124Controller : CrudApiController<TABLE124Dto, CreateTABLE124Dto, UpdateTABLE124Dto, long>
{
    public TABLE124Controller(ITABLE124Service service) : base(service, dto => dto.NPRODCLAS) { }
}
