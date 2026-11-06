using WEBVisualTime.Servicios.Insudb.DTOs.TABLE240;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE240Controller : CrudApiController<TABLE240Dto, CreateTABLE240Dto, UpdateTABLE240Dto, int>
{
    public TABLE240Controller(ITABLE240Service service) : base(service, dto => dto.NCATEGORY) { }
}
