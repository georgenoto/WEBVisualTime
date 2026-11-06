using WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPENDENCY_TYPES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class SDD_DEPENDENCY_TYPESController : CrudApiController<SDD_DEPENDENCY_TYPESDto, CreateSDD_DEPENDENCY_TYPESDto, UpdateSDD_DEPENDENCY_TYPESDto, int>
{
    public SDD_DEPENDENCY_TYPESController(ISDD_DEPENDENCY_TYPESService service) : base(service, dto => dto.IRID) { }
}
