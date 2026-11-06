using WEBVisualTime.Servicios.Insudb.DTOs.TABLE534;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE534Controller : CrudApiController<TABLE534Dto, CreateTABLE534Dto, UpdateTABLE534Dto, long>
{
    public TABLE534Controller(ITABLE534Service service) : base(service, dto => dto.NCESS_TYPE) { }
}
