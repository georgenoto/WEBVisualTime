using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8010;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8010Controller : CrudApiController<TABLE8010Dto, CreateTABLE8010Dto, UpdateTABLE8010Dto, long>
{
    public TABLE8010Controller(ITABLE8010Service service) : base(service, dto => dto.NCODIGINT) { }
}
