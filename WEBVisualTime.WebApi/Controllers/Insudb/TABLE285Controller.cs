using WEBVisualTime.Servicios.Insudb.DTOs.TABLE285;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE285Controller : CrudApiController<TABLE285Dto, CreateTABLE285Dto, UpdateTABLE285Dto, long>
{
    public TABLE285Controller(ITABLE285Service service) : base(service, dto => dto.NCODIGINT) { }
}
