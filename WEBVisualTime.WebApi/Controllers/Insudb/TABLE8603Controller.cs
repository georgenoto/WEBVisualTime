using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8603;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8603Controller : CrudApiController<TABLE8603Dto, CreateTABLE8603Dto, UpdateTABLE8603Dto, string>
{
    public TABLE8603Controller(ITABLE8603Service service) : base(service, dto => dto.SMEDSPECIALIALTY) { }
}
