using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9260;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9260Controller : CrudApiController<TABLE9260Dto, CreateTABLE9260Dto, UpdateTABLE9260Dto, int>
{
    public TABLE9260Controller(ITABLE9260Service service) : base(service, dto => dto.NPROCTYPEREN) { }
}
