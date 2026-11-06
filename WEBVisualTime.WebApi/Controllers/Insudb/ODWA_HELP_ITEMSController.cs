using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_ITEMS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class ODWA_HELP_ITEMSController : CrudApiController<ODWA_HELP_ITEMSDto, CreateODWA_HELP_ITEMSDto, UpdateODWA_HELP_ITEMSDto, int>
{
    public ODWA_HELP_ITEMSController(IODWA_HELP_ITEMSService service) : base(service, dto => dto.ID) { }
}
