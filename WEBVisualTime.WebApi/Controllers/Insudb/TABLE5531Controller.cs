using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5531;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5531Controller : CrudApiController<TABLE5531Dto, CreateTABLE5531Dto, UpdateTABLE5531Dto, int>
{
    public TABLE5531Controller(ITABLE5531Service service) : base(service, dto => dto.NCHANGE) { }
}
