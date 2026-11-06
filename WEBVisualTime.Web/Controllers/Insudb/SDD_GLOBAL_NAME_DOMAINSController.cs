using WEBVisualTime.Servicios.Insudb.DTOs.SDD_GLOBAL_NAME_DOMAINS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SDD_GLOBAL_NAME_DOMAINSController : CatalogController<SDD_GLOBAL_NAME_DOMAINSDto, CreateSDD_GLOBAL_NAME_DOMAINSDto, UpdateSDD_GLOBAL_NAME_DOMAINSDto, int>
{
    public SDD_GLOBAL_NAME_DOMAINSController(ISDD_GLOBAL_NAME_DOMAINSService service)
        : base(service, "SDD_GLOBAL_NAME_DOMAINS", "IRID", new[] { "IRID", "IVID", "NAME", "SYSTEM_FLAG", "NUMBER_OF_TIMES_MODIFIED", "DATE_CREATED", "CREATED_BY", "DATE_CHANGED", "CHANGED_BY" }) { }
}
