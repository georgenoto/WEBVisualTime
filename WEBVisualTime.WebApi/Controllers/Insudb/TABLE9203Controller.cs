using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9203;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9203Controller : CrudApiController<TABLE9203Dto, CreateTABLE9203Dto, UpdateTABLE9203Dto, int>
{
    public TABLE9203Controller(ITABLE9203Service service) : base(service, dto => dto.NTYPELIST) { }
}
