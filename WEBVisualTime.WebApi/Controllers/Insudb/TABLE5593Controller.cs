using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5593;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5593Controller : CrudApiController<TABLE5593Dto, CreateTABLE5593Dto, UpdateTABLE5593Dto, int>
{
    public TABLE5593Controller(ITABLE5593Service service) : base(service, dto => dto.NMEASUNIT) { }
}
