using WEBVisualTime.Servicios.Insudb.DTOs.TABLE268;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE268Controller : CrudApiController<TABLE268Dto, CreateTABLE268Dto, UpdateTABLE268Dto, int>
{
    public TABLE268Controller(ITABLE268Service service) : base(service, dto => dto.NGROUP_COMP) { }
}
