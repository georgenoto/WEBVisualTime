using WEBVisualTime.Servicios.Insudb.DTOs.TABLE289;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE289Controller : CrudApiController<TABLE289Dto, CreateTABLE289Dto, UpdateTABLE289Dto, long>
{
    public TABLE289Controller(ITABLE289Service service) : base(service, dto => dto.NCODIGINT) { }
}
