using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9236;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9236Controller : CrudApiController<TABLE9236Dto, CreateTABLE9236Dto, UpdateTABLE9236Dto, int>
{
    public TABLE9236Controller(ITABLE9236Service service) : base(service, dto => dto.NTYPE_ID) { }
}
