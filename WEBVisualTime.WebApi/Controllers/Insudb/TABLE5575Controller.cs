using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5575;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5575Controller : CrudApiController<TABLE5575Dto, CreateTABLE5575Dto, UpdateTABLE5575Dto, int>
{
    public TABLE5575Controller(ITABLE5575Service service) : base(service, dto => dto.NCHEOPERTYP) { }
}
