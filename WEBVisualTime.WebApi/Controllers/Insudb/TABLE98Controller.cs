using WEBVisualTime.Servicios.Insudb.DTOs.TABLE98;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE98Controller : CrudApiController<TABLE98Dto, CreateTABLE98Dto, UpdateTABLE98Dto, int>
{
    public TABLE98Controller(ITABLE98Service service) : base(service, dto => dto.NTYPE_REPORT) { }
}
