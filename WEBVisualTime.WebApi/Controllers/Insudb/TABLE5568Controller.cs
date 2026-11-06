using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5568;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5568Controller : CrudApiController<TABLE5568Dto, CreateTABLE5568Dto, UpdateTABLE5568Dto, int>
{
    public TABLE5568Controller(ITABLE5568Service service) : base(service, dto => dto.NSTATUS_COMM) { }
}
