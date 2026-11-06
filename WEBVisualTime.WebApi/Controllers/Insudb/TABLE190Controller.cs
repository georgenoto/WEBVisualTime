using WEBVisualTime.Servicios.Insudb.DTOs.TABLE190;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE190Controller : CrudApiController<TABLE190Dto, CreateTABLE190Dto, UpdateTABLE190Dto, int>
{
    public TABLE190Controller(ITABLE190Service service) : base(service, dto => dto.NACC_TYPE) { }
}
