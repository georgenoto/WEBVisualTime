using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9208;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9208Controller : CrudApiController<TABLE9208Dto, CreateTABLE9208Dto, UpdateTABLE9208Dto, int>
{
    public TABLE9208Controller(ITABLE9208Service service) : base(service, dto => dto.NTYPEXP) { }
}
