using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5639;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5639Controller : CrudApiController<TABLE5639Dto, CreateTABLE5639Dto, UpdateTABLE5639Dto, int>
{
    public TABLE5639Controller(ITABLE5639Service service) : base(service, dto => dto.NTYPERISK) { }
}
