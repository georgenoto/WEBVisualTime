using WEBVisualTime.Servicios.Insudb.DTOs.TABLE564;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE564Controller : CrudApiController<TABLE564Dto, CreateTABLE564Dto, UpdateTABLE564Dto, int>
{
    public TABLE564Controller(ITABLE564Service service) : base(service, dto => dto.NPHONE_TYPE) { }
}
