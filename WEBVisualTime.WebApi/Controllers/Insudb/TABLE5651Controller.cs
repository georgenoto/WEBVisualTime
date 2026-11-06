using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5651;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5651Controller : CrudApiController<TABLE5651Dto, CreateTABLE5651Dto, UpdateTABLE5651Dto, int>
{
    public TABLE5651Controller(ITABLE5651Service service) : base(service, dto => dto.NPREM_DET) { }
}
