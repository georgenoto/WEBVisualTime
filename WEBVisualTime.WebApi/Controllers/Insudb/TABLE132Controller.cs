using WEBVisualTime.Servicios.Insudb.DTOs.TABLE132;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE132Controller : CrudApiController<TABLE132Dto, CreateTABLE132Dto, UpdateTABLE132Dto, string>
{
    public TABLE132Controller(ITABLE132Service service) : base(service, dto => dto.SCLAIMTYP) { }
}
