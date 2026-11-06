using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9278;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9278Controller : CrudApiController<TABLE9278Dto, CreateTABLE9278Dto, UpdateTABLE9278Dto, int>
{
    public TABLE9278Controller(ITABLE9278Service service) : base(service, dto => dto.NSUM_INSURED_TYPE) { }
}
