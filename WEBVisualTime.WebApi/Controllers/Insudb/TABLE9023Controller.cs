using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9023;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9023Controller : CrudApiController<TABLE9023Dto, CreateTABLE9023Dto, UpdateTABLE9023Dto, int>
{
    public TABLE9023Controller(ITABLE9023Service service) : base(service, dto => dto.NLIQCURRENT) { }
}
