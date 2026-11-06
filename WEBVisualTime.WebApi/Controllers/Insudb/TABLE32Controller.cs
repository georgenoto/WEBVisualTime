using WEBVisualTime.Servicios.Insudb.DTOs.TABLE32;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE32Controller : CrudApiController<TABLE32Dto, CreateTABLE32Dto, UpdateTABLE32Dto, int>
{
    public TABLE32Controller(ITABLE32Service service) : base(service, dto => dto.NCRTHECNI) { }
}
