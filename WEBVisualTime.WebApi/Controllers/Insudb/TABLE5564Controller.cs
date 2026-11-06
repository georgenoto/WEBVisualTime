using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5564;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5564Controller : CrudApiController<TABLE5564Dto, CreateTABLE5564Dto, UpdateTABLE5564Dto, int>
{
    public TABLE5564Controller(ITABLE5564Service service) : base(service, dto => dto.NBILLSTAT) { }
}
