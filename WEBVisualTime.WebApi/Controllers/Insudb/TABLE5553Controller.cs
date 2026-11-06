using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5553;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5553Controller : CrudApiController<TABLE5553Dto, CreateTABLE5553Dto, UpdateTABLE5553Dto, int>
{
    public TABLE5553Controller(ITABLE5553Service service) : base(service, dto => dto.NCHEQUELOCAT) { }
}
