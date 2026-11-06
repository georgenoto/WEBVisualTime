using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5713;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5713Controller : CrudApiController<TABLE5713Dto, CreateTABLE5713Dto, UpdateTABLE5713Dto, int>
{
    public TABLE5713Controller(ITABLE5713Service service) : base(service, dto => dto.NTYPE) { }
}
