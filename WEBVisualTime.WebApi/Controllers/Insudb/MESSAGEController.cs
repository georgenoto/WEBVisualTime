using WEBVisualTime.Servicios.Insudb.DTOs.MESSAGE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class MESSAGEController : CrudApiController<MESSAGEDto, CreateMESSAGEDto, UpdateMESSAGEDto, long>
{
    public MESSAGEController(IMESSAGEService service) : base(service, dto => dto.NERRORNUM) { }
}
