using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5582;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5582Controller : CrudApiController<TABLE5582Dto, CreateTABLE5582Dto, UpdateTABLE5582Dto, int>
{
    public TABLE5582Controller(ITABLE5582Service service) : base(service, dto => dto.NTYPCOND) { }
}
