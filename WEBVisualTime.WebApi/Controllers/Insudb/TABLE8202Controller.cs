using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8202;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8202Controller : CrudApiController<TABLE8202Dto, CreateTABLE8202Dto, UpdateTABLE8202Dto, long>
{
    public TABLE8202Controller(ITABLE8202Service service) : base(service, dto => dto.NSTATUS) { }
}
