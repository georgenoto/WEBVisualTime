using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9202;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9202Controller : CrudApiController<TABLE9202Dto, CreateTABLE9202Dto, UpdateTABLE9202Dto, int>
{
    public TABLE9202Controller(ITABLE9202Service service) : base(service, dto => dto.NCATEGORY) { }
}
