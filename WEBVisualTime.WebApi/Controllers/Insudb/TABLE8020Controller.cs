using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8020;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8020Controller : CrudApiController<TABLE8020Dto, CreateTABLE8020Dto, UpdateTABLE8020Dto, long>
{
    public TABLE8020Controller(ITABLE8020Service service) : base(service, dto => dto.NCODIGINT) { }
}
