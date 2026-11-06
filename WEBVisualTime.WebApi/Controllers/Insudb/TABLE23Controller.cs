using WEBVisualTime.Servicios.Insudb.DTOs.TABLE23;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE23Controller : CrudApiController<TABLE23Dto, CreateTABLE23Dto, UpdateTABLE23Dto, long>
{
    public TABLE23Controller(ITABLE23Service service) : base(service, dto => dto.NCODIGINT) { }
}
