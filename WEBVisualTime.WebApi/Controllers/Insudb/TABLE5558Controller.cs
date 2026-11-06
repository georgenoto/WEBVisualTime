using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5558;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5558Controller : CrudApiController<TABLE5558Dto, CreateTABLE5558Dto, UpdateTABLE5558Dto, int>
{
    public TABLE5558Controller(ITABLE5558Service service) : base(service, dto => dto.NTYPEREC) { }
}
