using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5544;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5544Controller : CrudApiController<TABLE5544Dto, CreateTABLE5544Dto, UpdateTABLE5544Dto, int>
{
    public TABLE5544Controller(ITABLE5544Service service) : base(service, dto => dto.NTYPCOND) { }
}
