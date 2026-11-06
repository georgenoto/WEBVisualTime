using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5587;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5587Controller : CrudApiController<TABLE5587Dto, CreateTABLE5587Dto, UpdateTABLE5587Dto, int>
{
    public TABLE5587Controller(ITABLE5587Service service) : base(service, dto => dto.NCOLLECDOCTYP) { }
}
