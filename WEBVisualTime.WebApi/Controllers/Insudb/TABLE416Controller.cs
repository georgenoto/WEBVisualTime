using WEBVisualTime.Servicios.Insudb.DTOs.TABLE416;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE416Controller : CrudApiController<TABLE416Dto, CreateTABLE416Dto, UpdateTABLE416Dto, long>
{
    public TABLE416Controller(ITABLE416Service service) : base(service, dto => dto.NCONCEPT) { }
}
