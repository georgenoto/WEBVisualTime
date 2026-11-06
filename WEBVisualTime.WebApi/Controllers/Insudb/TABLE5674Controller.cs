using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5674;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5674Controller : CrudApiController<TABLE5674Dto, CreateTABLE5674Dto, UpdateTABLE5674Dto, int>
{
    public TABLE5674Controller(ITABLE5674Service service) : base(service, dto => dto.NMAG_DAM) { }
}
