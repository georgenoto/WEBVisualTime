using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9210;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9210Controller : CrudApiController<TABLE9210Dto, CreateTABLE9210Dto, UpdateTABLE9210Dto, int>
{
    public TABLE9210Controller(ITABLE9210Service service) : base(service, dto => dto.NTEMPASSI) { }
}
