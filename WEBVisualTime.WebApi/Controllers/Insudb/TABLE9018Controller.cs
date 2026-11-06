using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9018;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9018Controller : CrudApiController<TABLE9018Dto, CreateTABLE9018Dto, UpdateTABLE9018Dto, int>
{
    public TABLE9018Controller(ITABLE9018Service service) : base(service, dto => dto.NREFLAW) { }
}
