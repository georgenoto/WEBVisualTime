using WEBVisualTime.Servicios.Insudb.DTOs.TABLE307;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE307Controller : CrudApiController<TABLE307Dto, CreateTABLE307Dto, UpdateTABLE307Dto, long>
{
    public TABLE307Controller(ITABLE307Service service) : base(service, dto => dto.NCODIGINT) { }
}
