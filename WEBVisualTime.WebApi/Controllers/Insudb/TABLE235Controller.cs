using WEBVisualTime.Servicios.Insudb.DTOs.TABLE235;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE235Controller : CrudApiController<TABLE235Dto, CreateTABLE235Dto, UpdateTABLE235Dto, string>
{
    public TABLE235Controller(ITABLE235Service service) : base(service, dto => dto.SDECLA_TYPE) { }
}
