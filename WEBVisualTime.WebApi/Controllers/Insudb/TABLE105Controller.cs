using WEBVisualTime.Servicios.Insudb.DTOs.TABLE105;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE105Controller : CrudApiController<TABLE105Dto, CreateTABLE105Dto, UpdateTABLE105Dto, string>
{
    public TABLE105Controller(ITABLE105Service service) : base(service, dto => dto.STYPE) { }
}
