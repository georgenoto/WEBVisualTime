using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5589;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5589Controller : CrudApiController<TABLE5589Dto, CreateTABLE5589Dto, UpdateTABLE5589Dto, int>
{
    public TABLE5589Controller(ITABLE5589Service service) : base(service, dto => dto.NTYPDUR) { }
}
