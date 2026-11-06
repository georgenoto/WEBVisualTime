using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9252;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9252Controller : CrudApiController<TABLE9252Dto, CreateTABLE9252Dto, UpdateTABLE9252Dto, int>
{
    public TABLE9252Controller(ITABLE9252Service service) : base(service, dto => dto.NPAYMENT_METHOD) { }
}
