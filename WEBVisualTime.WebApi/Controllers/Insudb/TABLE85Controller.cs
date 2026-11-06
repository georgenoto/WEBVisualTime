using WEBVisualTime.Servicios.Insudb.DTOs.TABLE85;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE85Controller : CrudApiController<TABLE85Dto, CreateTABLE85Dto, UpdateTABLE85Dto, int>
{
    public TABLE85Controller(ITABLE85Service service) : base(service, dto => dto.NLANGUAGE) { }
}
