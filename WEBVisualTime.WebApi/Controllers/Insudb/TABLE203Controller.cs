using WEBVisualTime.Servicios.Insudb.DTOs.TABLE203;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE203Controller : CrudApiController<TABLE203Dto, CreateTABLE203Dto, UpdateTABLE203Dto, int>
{
    public TABLE203Controller(ITABLE203Service service) : base(service, dto => dto.NSTATUS_DOC) { }
}
