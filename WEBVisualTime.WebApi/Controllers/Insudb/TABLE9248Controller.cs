using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9248;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9248Controller : CrudApiController<TABLE9248Dto, CreateTABLE9248Dto, UpdateTABLE9248Dto, int>
{
    public TABLE9248Controller(ITABLE9248Service service) : base(service, dto => dto.NSTATUS) { }
}
