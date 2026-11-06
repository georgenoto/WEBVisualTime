using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5585;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5585Controller : CrudApiController<TABLE5585Dto, CreateTABLE5585Dto, UpdateTABLE5585Dto, int>
{
    public TABLE5585Controller(ITABLE5585Service service) : base(service, dto => dto.NTYPEMOV) { }
}
