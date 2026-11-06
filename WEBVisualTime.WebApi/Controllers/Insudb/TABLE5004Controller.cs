using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5004;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5004Controller : CrudApiController<TABLE5004Dto, CreateTABLE5004Dto, UpdateTABLE5004Dto, int>
{
    public TABLE5004Controller(ITABLE5004Service service) : base(service, dto => dto.NSTATUS) { }
}
