using WEBVisualTime.Servicios.Insudb.DTOs.TABLE521;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE521Controller : CrudApiController<TABLE521Dto, CreateTABLE521Dto, UpdateTABLE521Dto, int>
{
    public TABLE521Controller(ITABLE521Service service) : base(service, dto => dto.NINF_ORDER) { }
}
