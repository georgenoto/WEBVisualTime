using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5543;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5543Controller : CrudApiController<TABLE5543Dto, CreateTABLE5543Dto, UpdateTABLE5543Dto, int>
{
    public TABLE5543Controller(ITABLE5543Service service) : base(service, dto => dto.NPROTEC_TYPE) { }
}
