using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_NODES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class ODWA_HELP_NODESController : CrudApiController<ODWA_HELP_NODESDto, CreateODWA_HELP_NODESDto, UpdateODWA_HELP_NODESDto, int>
{
    public ODWA_HELP_NODESController(IODWA_HELP_NODESService service) : base(service, dto => dto.ID) { }
}
