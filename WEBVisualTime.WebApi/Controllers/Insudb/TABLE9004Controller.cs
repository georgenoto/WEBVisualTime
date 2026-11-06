using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9004;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9004Controller : CrudApiController<TABLE9004Dto, CreateTABLE9004Dto, UpdateTABLE9004Dto, int>
{
    public TABLE9004Controller(ITABLE9004Service service) : base(service, dto => dto.NCLASSCLIENT) { }
}
