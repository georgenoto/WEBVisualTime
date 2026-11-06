using WEBVisualTime.Servicios.Insudb.DTOs.TABLE161;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE161Controller : CrudApiController<TABLE161Dto, CreateTABLE161Dto, UpdateTABLE161Dto, string>
{
    public TABLE161Controller(ITABLE161Service service) : base(service, dto => dto.SSTYLE_COMM) { }
}
