using WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPEND_STATUSES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class SDD_DEPEND_STATUSESController : CrudApiController<SDD_DEPEND_STATUSESDto, CreateSDD_DEPEND_STATUSESDto, UpdateSDD_DEPEND_STATUSESDto, string>
{
    public SDD_DEPEND_STATUSESController(ISDD_DEPEND_STATUSESService service) : base(service, dto => dto.STATUS) { }
}
