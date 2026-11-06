using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5673;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5673Controller : CrudApiController<TABLE5673Dto, CreateTABLE5673Dto, UpdateTABLE5673Dto, int>
{
    public TABLE5673Controller(ITABLE5673Service service) : base(service, dto => dto.NINFORTYP) { }
}
