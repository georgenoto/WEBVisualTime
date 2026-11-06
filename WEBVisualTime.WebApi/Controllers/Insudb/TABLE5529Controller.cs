using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5529;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5529Controller : CrudApiController<TABLE5529Dto, CreateTABLE5529Dto, UpdateTABLE5529Dto, int>
{
    public TABLE5529Controller(ITABLE5529Service service) : base(service, dto => dto.NTYPEAGREE) { }
}
