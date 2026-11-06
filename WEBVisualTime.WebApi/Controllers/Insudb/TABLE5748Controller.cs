using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5748;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5748Controller : CrudApiController<TABLE5748Dto, CreateTABLE5748Dto, UpdateTABLE5748Dto, int>
{
    public TABLE5748Controller(ITABLE5748Service service) : base(service, dto => dto.NTYPEAGE) { }
}
