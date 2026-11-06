using WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPEND_STATUSES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SDD_DEPEND_STATUSESController : CatalogController<SDD_DEPEND_STATUSESDto, CreateSDD_DEPEND_STATUSESDto, UpdateSDD_DEPEND_STATUSESDto, string>
{
    public SDD_DEPEND_STATUSESController(ISDD_DEPEND_STATUSESService service)
        : base(service, "SDD_DEPEND_STATUSES", "STATUS", new[] { "STATUS", "DESCRIPTION", "SYSTEM_FLAG", "NUMBER_OF_TIMES_MODIFIED", "DATE_CREATED", "CREATED_BY", "DATE_CHANGED", "CHANGED_BY" }) { }
}
