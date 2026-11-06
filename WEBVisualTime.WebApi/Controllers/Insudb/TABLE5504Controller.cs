using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5504;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5504Controller : CrudApiController<TABLE5504Dto, CreateTABLE5504Dto, UpdateTABLE5504Dto, int>
{
    public TABLE5504Controller(ITABLE5504Service service) : base(service, dto => dto.NTYPDRIVER) { }
}
