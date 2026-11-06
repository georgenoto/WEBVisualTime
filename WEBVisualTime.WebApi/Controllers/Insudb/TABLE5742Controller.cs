using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5742;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5742Controller : CrudApiController<TABLE5742Dto, CreateTABLE5742Dto, UpdateTABLE5742Dto, int>
{
    public TABLE5742Controller(ITABLE5742Service service) : base(service, dto => dto.NTYPE_SAAPV) { }
}
