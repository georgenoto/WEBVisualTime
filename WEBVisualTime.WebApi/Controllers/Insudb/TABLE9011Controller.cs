using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9011;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9011Controller : CrudApiController<TABLE9011Dto, CreateTABLE9011Dto, UpdateTABLE9011Dto, int>
{
    public TABLE9011Controller(ITABLE9011Service service) : base(service, dto => dto.NCNTRYRISK) { }
}
