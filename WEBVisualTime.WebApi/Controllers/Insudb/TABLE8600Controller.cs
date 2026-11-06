using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8600;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8600Controller : CrudApiController<TABLE8600Dto, CreateTABLE8600Dto, UpdateTABLE8600Dto, string>
{
    public TABLE8600Controller(ITABLE8600Service service) : base(service, dto => dto.STYPEBENEFIT) { }
}
