using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5565;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5565Controller : CrudApiController<TABLE5565Dto, CreateTABLE5565Dto, UpdateTABLE5565Dto, int>
{
    public TABLE5565Controller(ITABLE5565Service service) : base(service, dto => dto.NTYPECODE) { }
}
