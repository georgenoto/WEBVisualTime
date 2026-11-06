using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9056;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9056Controller : CrudApiController<TABLE9056Dto, CreateTABLE9056Dto, UpdateTABLE9056Dto, int>
{
    public TABLE9056Controller(ITABLE9056Service service) : base(service, dto => dto.NDUPLICATEDTYPE) { }
}
