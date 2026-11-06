using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7200;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7200Controller : CrudApiController<TABLE7200Dto, CreateTABLE7200Dto, UpdateTABLE7200Dto, int>
{
    public TABLE7200Controller(ITABLE7200Service service) : base(service, dto => dto.NCODIGINT) { }
}
