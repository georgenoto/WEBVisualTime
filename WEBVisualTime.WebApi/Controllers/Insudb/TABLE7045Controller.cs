using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7045;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7045Controller : CrudApiController<TABLE7045Dto, CreateTABLE7045Dto, UpdateTABLE7045Dto, int>
{
    public TABLE7045Controller(ITABLE7045Service service) : base(service, dto => dto.NACTIVITYTYPE) { }
}
