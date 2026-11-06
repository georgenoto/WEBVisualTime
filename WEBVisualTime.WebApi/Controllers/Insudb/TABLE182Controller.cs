using WEBVisualTime.Servicios.Insudb.DTOs.TABLE182;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE182Controller : CrudApiController<TABLE182Dto, CreateTABLE182Dto, UpdateTABLE182Dto, string>
{
    public TABLE182Controller(ITABLE182Service service) : base(service, dto => dto.SPAY_FORM) { }
}
