using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9276;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9276Controller : CrudApiController<TABLE9276Dto, CreateTABLE9276Dto, UpdateTABLE9276Dto, int>
{
    public TABLE9276Controller(ITABLE9276Service service) : base(service, dto => dto.NMOVEMENT_TYPE) { }
}
