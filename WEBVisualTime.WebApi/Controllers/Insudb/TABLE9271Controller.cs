using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9271;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9271Controller : CrudApiController<TABLE9271Dto, CreateTABLE9271Dto, UpdateTABLE9271Dto, int>
{
    public TABLE9271Controller(ITABLE9271Service service) : base(service, dto => dto.NCAUSEREOPENCL) { }
}
