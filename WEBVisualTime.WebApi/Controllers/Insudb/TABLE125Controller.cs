using WEBVisualTime.Servicios.Insudb.DTOs.TABLE125;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE125Controller : CrudApiController<TABLE125Dto, CreateTABLE125Dto, UpdateTABLE125Dto, long>
{
    public TABLE125Controller(ITABLE125Service service) : base(service, dto => dto.NVALUESTY) { }
}
