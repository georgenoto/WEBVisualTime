using WEBVisualTime.Servicios.Insudb.DTOs.TABLE532;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE532Controller : CrudApiController<TABLE532Dto, CreateTABLE532Dto, UpdateTABLE532Dto, int>
{
    public TABLE532Controller(ITABLE532Service service) : base(service, dto => dto.NTYP_AMOUNT) { }
}
