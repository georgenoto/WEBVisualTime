using WEBVisualTime.Servicios.Insudb.DTOs.TABLE88;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE88Controller : CrudApiController<TABLE88Dto, CreateTABLE88Dto, UpdateTABLE88Dto, int>
{
    public TABLE88Controller(ITABLE88Service service) : base(service, dto => dto.NWINDOWTY) { }
}
