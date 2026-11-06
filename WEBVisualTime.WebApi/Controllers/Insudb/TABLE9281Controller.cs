using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9281;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9281Controller : CrudApiController<TABLE9281Dto, CreateTABLE9281Dto, UpdateTABLE9281Dto, int>
{
    public TABLE9281Controller(ITABLE9281Service service) : base(service, dto => dto.NSERVICE_TYPE) { }
}
