using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9019;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9019Controller : CrudApiController<TABLE9019Dto, CreateTABLE9019Dto, UpdateTABLE9019Dto, int>
{
    public TABLE9019Controller(ITABLE9019Service service) : base(service, dto => dto.NNUMPAYS) { }
}
