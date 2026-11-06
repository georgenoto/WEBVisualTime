using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5810;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5810Controller : CrudApiController<TABLE5810Dto, CreateTABLE5810Dto, UpdateTABLE5810Dto, int>
{
    public TABLE5810Controller(ITABLE5810Service service) : base(service, dto => dto.NQAMENTYPE) { }
}
