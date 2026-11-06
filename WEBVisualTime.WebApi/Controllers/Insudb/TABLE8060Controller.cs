using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8060;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8060Controller : CrudApiController<TABLE8060Dto, CreateTABLE8060Dto, UpdateTABLE8060Dto, long>
{
    public TABLE8060Controller(ITABLE8060Service service) : base(service, dto => dto.NBESTTIMETOCALL) { }
}
