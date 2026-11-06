using WEBVisualTime.Servicios.Insudb.DTOs.TABLE187;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE187Controller : CrudApiController<TABLE187Dto, CreateTABLE187Dto, UpdateTABLE187Dto, int>
{
    public TABLE187Controller(ITABLE187Service service) : base(service, dto => dto.NSTA_CHEQUE) { }
}
