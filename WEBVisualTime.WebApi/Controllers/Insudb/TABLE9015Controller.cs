using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9015;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9015Controller : CrudApiController<TABLE9015Dto, CreateTABLE9015Dto, UpdateTABLE9015Dto, int>
{
    public TABLE9015Controller(ITABLE9015Service service) : base(service, dto => dto.NACTBUS) { }
}
