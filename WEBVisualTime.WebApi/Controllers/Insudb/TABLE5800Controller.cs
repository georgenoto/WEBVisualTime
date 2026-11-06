using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5800;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5800Controller : CrudApiController<TABLE5800Dto, CreateTABLE5800Dto, UpdateTABLE5800Dto, int>
{
    public TABLE5800Controller(ITABLE5800Service service) : base(service, dto => dto.NID_TABLE) { }
}
