using WEBVisualTime.Servicios.Insudb.DTOs.TABLE533;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE533Controller : CrudApiController<TABLE533Dto, CreateTABLE533Dto, UpdateTABLE533Dto, int>
{
    public TABLE533Controller(ITABLE533Service service) : base(service, dto => dto.NCONCEPT) { }
}
