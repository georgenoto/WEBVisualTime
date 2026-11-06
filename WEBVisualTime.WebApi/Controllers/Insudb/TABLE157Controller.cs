using WEBVisualTime.Servicios.Insudb.DTOs.TABLE157;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE157Controller : CrudApiController<TABLE157Dto, CreateTABLE157Dto, UpdateTABLE157Dto, long>
{
    public TABLE157Controller(ITABLE157Service service) : base(service, dto => dto.SCODIGINT) { }
}
