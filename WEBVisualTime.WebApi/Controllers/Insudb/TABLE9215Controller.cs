using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9215;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9215Controller : CrudApiController<TABLE9215Dto, CreateTABLE9215Dto, UpdateTABLE9215Dto, int>
{
    public TABLE9215Controller(ITABLE9215Service service) : base(service, dto => dto.NATTENSYSTEM) { }
}
