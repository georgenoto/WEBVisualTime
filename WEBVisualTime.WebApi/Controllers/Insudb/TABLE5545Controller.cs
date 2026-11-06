using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5545;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5545Controller : CrudApiController<TABLE5545Dto, CreateTABLE5545Dto, UpdateTABLE5545Dto, int>
{
    public TABLE5545Controller(ITABLE5545Service service) : base(service, dto => dto.NTYPELOAD) { }
}
