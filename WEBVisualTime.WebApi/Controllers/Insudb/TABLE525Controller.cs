using WEBVisualTime.Servicios.Insudb.DTOs.TABLE525;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE525Controller : CrudApiController<TABLE525Dto, CreateTABLE525Dto, UpdateTABLE525Dto, int>
{
    public TABLE525Controller(ITABLE525Service service) : base(service, dto => dto.NMOD_TYPE) { }
}
