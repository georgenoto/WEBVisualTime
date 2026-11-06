using WEBVisualTime.Servicios.Insudb.DTOs.TABLE33;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE33Controller : CrudApiController<TABLE33Dto, CreateTABLE33Dto, UpdateTABLE33Dto, string>
{
    public TABLE33Controller(ITABLE33Service service) : base(service, dto => dto.SFRANCAPL) { }
}
