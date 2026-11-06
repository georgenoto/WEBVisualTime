using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5610;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5610Controller : CrudApiController<TABLE5610Dto, CreateTABLE5610Dto, UpdateTABLE5610Dto, int>
{
    public TABLE5610Controller(ITABLE5610Service service) : base(service, dto => dto.NTYPEREC) { }
}
