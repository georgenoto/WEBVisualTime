using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5741;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5741Controller : CrudApiController<TABLE5741Dto, CreateTABLE5741Dto, UpdateTABLE5741Dto, int>
{
    public TABLE5741Controller(ITABLE5741Service service) : base(service, dto => dto.NCODE_STATE) { }
}
