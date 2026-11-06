using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9028;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9028Controller : CrudApiController<TABLE9028Dto, CreateTABLE9028Dto, UpdateTABLE9028Dto, int>
{
    public TABLE9028Controller(ITABLE9028Service service) : base(service, dto => dto.NFINANCIAL) { }
}
