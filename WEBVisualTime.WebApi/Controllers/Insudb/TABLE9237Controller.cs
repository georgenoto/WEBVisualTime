using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9237;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9237Controller : CrudApiController<TABLE9237Dto, CreateTABLE9237Dto, UpdateTABLE9237Dto, int>
{
    public TABLE9237Controller(ITABLE9237Service service) : base(service, dto => dto.NATTENTCHANNEL) { }
}
