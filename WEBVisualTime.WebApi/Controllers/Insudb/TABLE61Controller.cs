using WEBVisualTime.Servicios.Insudb.DTOs.TABLE61;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE61Controller : CrudApiController<TABLE61Dto, CreateTABLE61Dto, UpdateTABLE61Dto, int>
{
    public TABLE61Controller(ITABLE61Service service) : base(service, dto => dto.NORIGIN) { }
}
