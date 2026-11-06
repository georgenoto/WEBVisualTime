using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9275;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9275Controller : CrudApiController<TABLE9275Dto, CreateTABLE9275Dto, UpdateTABLE9275Dto, int>
{
    public TABLE9275Controller(ITABLE9275Service service) : base(service, dto => dto.NSTATUS) { }
}
