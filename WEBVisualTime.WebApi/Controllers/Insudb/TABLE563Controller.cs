using WEBVisualTime.Servicios.Insudb.DTOs.TABLE563;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE563Controller : CrudApiController<TABLE563Dto, CreateTABLE563Dto, UpdateTABLE563Dto, long>
{
    public TABLE563Controller(ITABLE563Service service) : base(service, dto => dto.NCODIGINT) { }
}
