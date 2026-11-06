using WEBVisualTime.Servicios.Insudb.DTOs.TABLE256;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE256Controller : CrudApiController<TABLE256Dto, CreateTABLE256Dto, UpdateTABLE256Dto, long>
{
    public TABLE256Controller(ITABLE256Service service) : base(service, dto => dto.NCODIGINT) { }
}
