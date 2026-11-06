using WEBVisualTime.Servicios.Insudb.DTOs.TABLE24;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE24Controller : CrudApiController<TABLE24Dto, CreateTABLE24Dto, UpdateTABLE24Dto, int>
{
    public TABLE24Controller(ITABLE24Service service) : base(service, dto => dto.NTRATYPEI) { }
}
