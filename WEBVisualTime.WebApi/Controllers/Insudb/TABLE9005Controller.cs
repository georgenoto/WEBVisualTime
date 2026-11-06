using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9005;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9005Controller : CrudApiController<TABLE9005Dto, CreateTABLE9005Dto, UpdateTABLE9005Dto, int>
{
    public TABLE9005Controller(ITABLE9005Service service) : base(service, dto => dto.NBUSINESSTY) { }
}
