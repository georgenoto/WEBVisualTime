using WEBVisualTime.Servicios.Insudb.DTOs.TABLE998;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE998Controller : CrudApiController<TABLE998Dto, CreateTABLE998Dto, UpdateTABLE998Dto, int>
{
    public TABLE998Controller(ITABLE998Service service) : base(service, dto => dto.NCOMPTYPE) { }
}
