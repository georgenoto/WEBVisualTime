using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_PREFERENCES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class ODWA_PREFERENCESController : CrudApiController<ODWA_PREFERENCESDto, CreateODWA_PREFERENCESDto, UpdateODWA_PREFERENCESDto, string>
{
    public ODWA_PREFERENCESController(IODWA_PREFERENCESService service) : base(service, dto => dto.PREFERENCE_NAME) { }
}
