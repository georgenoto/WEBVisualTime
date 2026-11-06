using WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPENDENCY_TYPES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SDD_DEPENDENCY_TYPESController : CatalogController<SDD_DEPENDENCY_TYPESDto, CreateSDD_DEPENDENCY_TYPESDto, UpdateSDD_DEPENDENCY_TYPESDto, int>
{
    public SDD_DEPENDENCY_TYPESController(ISDD_DEPENDENCY_TYPESService service)
        : base(service, "SDD_DEPENDENCY_TYPES", "IRID", new[] { "IRID", "IVID", "TYPE", "SYSTEM_FLAG", "TRANSITIVE", "NUMBER_OF_TIMES_MODIFIED", "DATE_CREATED", "CREATED_BY", "DATE_CHANGED", "CHANGED_BY", "SUBTYPE" }) { }
}
