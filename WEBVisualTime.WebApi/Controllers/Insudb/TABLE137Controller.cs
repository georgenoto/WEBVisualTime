using WEBVisualTime.Servicios.Insudb.DTOs.TABLE137;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE137Controller : CrudApiController<TABLE137Dto, CreateTABLE137Dto, UpdateTABLE137Dto, int>
{
    public TABLE137Controller(ITABLE137Service service) : base(service, dto => dto.NTYPE_PAY) { }
}
