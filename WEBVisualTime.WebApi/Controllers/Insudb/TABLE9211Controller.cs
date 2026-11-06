using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9211;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9211Controller : CrudApiController<TABLE9211Dto, CreateTABLE9211Dto, UpdateTABLE9211Dto, int>
{
    public TABLE9211Controller(ITABLE9211Service service) : base(service, dto => dto.NRETENTION) { }
}
