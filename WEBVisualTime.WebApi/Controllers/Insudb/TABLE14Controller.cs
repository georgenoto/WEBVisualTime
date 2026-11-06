using WEBVisualTime.Servicios.Insudb.DTOs.TABLE14;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE14Controller : CrudApiController<TABLE14Dto, CreateTABLE14Dto, UpdateTABLE14Dto, int>
{
    public TABLE14Controller(ITABLE14Service service) : base(service, dto => dto.NCIVILSTA) { }
}
