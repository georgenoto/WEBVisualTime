using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5770;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5770Controller : CrudApiController<TABLE5770Dto, CreateTABLE5770Dto, UpdateTABLE5770Dto, int>
{
    public TABLE5770Controller(ITABLE5770Service service) : base(service, dto => dto.NSPECIALBUSINES) { }
}
