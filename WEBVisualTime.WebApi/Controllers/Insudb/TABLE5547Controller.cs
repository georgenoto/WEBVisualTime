using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5547;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5547Controller : CrudApiController<TABLE5547Dto, CreateTABLE5547Dto, UpdateTABLE5547Dto, int>
{
    public TABLE5547Controller(ITABLE5547Service service) : base(service, dto => dto.NCAUSEUPD) { }
}
