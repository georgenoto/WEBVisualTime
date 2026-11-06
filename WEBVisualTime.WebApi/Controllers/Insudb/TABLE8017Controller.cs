using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8017;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8017Controller : CrudApiController<TABLE8017Dto, CreateTABLE8017Dto, UpdateTABLE8017Dto, int>
{
    public TABLE8017Controller(ITABLE8017Service service) : base(service, dto => dto.NFIELD) { }
}
