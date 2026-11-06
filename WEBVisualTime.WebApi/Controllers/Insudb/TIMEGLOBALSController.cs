using WEBVisualTime.Servicios.Insudb.DTOs.TIMEGLOBALS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TIMEGLOBALSController : CrudApiController<TIMEGLOBALSDto, CreateTIMEGLOBALSDto, UpdateTIMEGLOBALSDto, string>
{
    public TIMEGLOBALSController(ITIMEGLOBALSService service) : base(service, dto => dto.SCODE) { }
}
