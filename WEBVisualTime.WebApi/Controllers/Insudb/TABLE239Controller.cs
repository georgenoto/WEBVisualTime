using WEBVisualTime.Servicios.Insudb.DTOs.TABLE239;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE239Controller : CrudApiController<TABLE239Dto, CreateTABLE239Dto, UpdateTABLE239Dto, int>
{
    public TABLE239Controller(ITABLE239Service service) : base(service, dto => dto.NUBICATION) { }
}
