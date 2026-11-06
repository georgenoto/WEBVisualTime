using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9020;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9020Controller : CrudApiController<TABLE9020Dto, CreateTABLE9020Dto, UpdateTABLE9020Dto, int>
{
    public TABLE9020Controller(ITABLE9020Service service) : base(service, dto => dto.NOLDINSURANCE) { }
}
