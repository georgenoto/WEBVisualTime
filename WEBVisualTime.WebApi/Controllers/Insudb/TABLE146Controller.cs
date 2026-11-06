using WEBVisualTime.Servicios.Insudb.DTOs.TABLE146;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE146Controller : CrudApiController<TABLE146Dto, CreateTABLE146Dto, UpdateTABLE146Dto, int>
{
    public TABLE146Controller(ITABLE146Service service) : base(service, dto => dto.NCLASS) { }
}
