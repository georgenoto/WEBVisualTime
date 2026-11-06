using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8604;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8604Controller : CrudApiController<TABLE8604Dto, CreateTABLE8604Dto, UpdateTABLE8604Dto, string>
{
    public TABLE8604Controller(ITABLE8604Service service) : base(service, dto => dto.STYPECARE) { }
}
