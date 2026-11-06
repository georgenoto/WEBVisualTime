using WEBVisualTime.Servicios.Insudb.DTOs.TABLE417;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE417Controller : CrudApiController<TABLE417Dto, CreateTABLE417Dto, UpdateTABLE417Dto, long>
{
    public TABLE417Controller(ITABLE417Service service) : base(service, dto => dto.NCODIGINT) { }
}
