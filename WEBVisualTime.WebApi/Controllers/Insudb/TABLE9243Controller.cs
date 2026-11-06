using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9243;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9243Controller : CrudApiController<TABLE9243Dto, CreateTABLE9243Dto, UpdateTABLE9243Dto, int>
{
    public TABLE9243Controller(ITABLE9243Service service) : base(service, dto => dto.NMOVEMENT_TYPE) { }
}
