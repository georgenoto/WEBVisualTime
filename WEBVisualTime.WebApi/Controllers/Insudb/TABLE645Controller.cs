using WEBVisualTime.Servicios.Insudb.DTOs.TABLE645;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE645Controller : CrudApiController<TABLE645Dto, CreateTABLE645Dto, UpdateTABLE645Dto, long>
{
    public TABLE645Controller(ITABLE645Service service) : base(service, dto => dto.NCODIGINT) { }
}
