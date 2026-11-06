using WEBVisualTime.Servicios.Insudb.DTOs.TABLE415;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE415Controller : CrudApiController<TABLE415Dto, CreateTABLE415Dto, UpdateTABLE415Dto, int>
{
    public TABLE415Controller(ITABLE415Service service) : base(service, dto => dto.NMOVE_TYPE) { }
}
