using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5599;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5599Controller : CrudApiController<TABLE5599Dto, CreateTABLE5599Dto, UpdateTABLE5599Dto, int>
{
    public TABLE5599Controller(ITABLE5599Service service) : base(service, dto => dto.NILLUSTTYPE) { }
}
