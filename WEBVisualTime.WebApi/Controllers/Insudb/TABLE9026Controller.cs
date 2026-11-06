using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9026;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9026Controller : CrudApiController<TABLE9026Dto, CreateTABLE9026Dto, UpdateTABLE9026Dto, int>
{
    public TABLE9026Controller(ITABLE9026Service service) : base(service, dto => dto.NGROWSALES) { }
}
