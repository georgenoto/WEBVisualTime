using WEBVisualTime.Servicios.Insudb.DTOs.TABLE248;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE248Controller : CrudApiController<TABLE248Dto, CreateTABLE248Dto, UpdateTABLE248Dto, int>
{
    public TABLE248Controller(ITABLE248Service service) : base(service, dto => dto.NRISK) { }
}
