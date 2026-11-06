using WEBVisualTime.Servicios.Insudb.DTOs.TABLE221;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE221Controller : CrudApiController<TABLE221Dto, CreateTABLE221Dto, UpdateTABLE221Dto, long>
{
    public TABLE221Controller(ITABLE221Service service) : base(service, dto => dto.NCODIGINT) { }
}
