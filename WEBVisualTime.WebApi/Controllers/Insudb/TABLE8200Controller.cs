using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8200;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8200Controller : CrudApiController<TABLE8200Dto, CreateTABLE8200Dto, UpdateTABLE8200Dto, int>
{
    public TABLE8200Controller(ITABLE8200Service service) : base(service, dto => dto.NPROCESS) { }
}
