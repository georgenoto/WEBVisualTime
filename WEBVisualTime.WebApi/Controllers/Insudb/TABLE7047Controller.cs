using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7047;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7047Controller : CrudApiController<TABLE7047Dto, CreateTABLE7047Dto, UpdateTABLE7047Dto, int>
{
    public TABLE7047Controller(ITABLE7047Service service) : base(service, dto => dto.NSEISMICZONE) { }
}
