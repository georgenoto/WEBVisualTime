using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9006;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9006Controller : CrudApiController<TABLE9006Dto, CreateTABLE9006Dto, UpdateTABLE9006Dto, int>
{
    public TABLE9006Controller(ITABLE9006Service service) : base(service, dto => dto.NCONSTCLASS) { }
}
