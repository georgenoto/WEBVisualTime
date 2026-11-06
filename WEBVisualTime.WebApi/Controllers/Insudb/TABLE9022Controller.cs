using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9022;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9022Controller : CrudApiController<TABLE9022Dto, CreateTABLE9022Dto, UpdateTABLE9022Dto, int>
{
    public TABLE9022Controller(ITABLE9022Service service) : base(service, dto => dto.NCREDITREASON) { }
}
