using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7212;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7212Controller : CrudApiController<TABLE7212Dto, CreateTABLE7212Dto, UpdateTABLE7212Dto, int>
{
    public TABLE7212Controller(ITABLE7212Service service) : base(service, dto => dto.NTYPE) { }
}
