using WEBVisualTime.Servicios.Insudb.DTOs.TABLE41;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE41Controller : CrudApiController<TABLE41Dto, CreateTABLE41Dto, UpdateTABLE41Dto, long>
{
    public TABLE41Controller(ITABLE41Service service) : base(service, dto => dto.NCODIGINT) { }
}
