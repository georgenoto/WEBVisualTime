using WEBVisualTime.Servicios.Insudb.DTOs.TABLE249;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE249Controller : CrudApiController<TABLE249Dto, CreateTABLE249Dto, UpdateTABLE249Dto, long>
{
    public TABLE249Controller(ITABLE249Service service) : base(service, dto => dto.NCODIGINT) { }
}
