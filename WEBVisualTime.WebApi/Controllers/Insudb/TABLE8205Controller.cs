using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8205;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8205Controller : CrudApiController<TABLE8205Dto, CreateTABLE8205Dto, UpdateTABLE8205Dto, int>
{
    public TABLE8205Controller(ITABLE8205Service service) : base(service, dto => dto.NSECTION) { }
}
