using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8320;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8320Controller : CrudApiController<TABLE8320Dto, CreateTABLE8320Dto, UpdateTABLE8320Dto, int>
{
    public TABLE8320Controller(ITABLE8320Service service) : base(service, dto => dto.NTYPEPROFILE) { }
}
