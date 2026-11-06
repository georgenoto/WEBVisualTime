using WEBVisualTime.Servicios.Insudb.DTOs.APPUSER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class APPUSERController : CrudApiController<APPUSERDto, CreateAPPUSERDto, UpdateAPPUSERDto, int>
{
    public APPUSERController(IAPPUSERService service) : base(service, dto => dto.NIDUSER) { }
}
