using WEBVisualTime.Servicios.Insudb.DTOs.SDD_GLOBAL_NAME_DOMAINS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class SDD_GLOBAL_NAME_DOMAINSController : CrudApiController<SDD_GLOBAL_NAME_DOMAINSDto, CreateSDD_GLOBAL_NAME_DOMAINSDto, UpdateSDD_GLOBAL_NAME_DOMAINSDto, int>
{
    public SDD_GLOBAL_NAME_DOMAINSController(ISDD_GLOBAL_NAME_DOMAINSService service) : base(service, dto => dto.IRID) { }
}
