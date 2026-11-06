using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5671;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5671Controller : CrudApiController<TABLE5671Dto, CreateTABLE5671Dto, UpdateTABLE5671Dto, int>
{
    public TABLE5671Controller(ITABLE5671Service service) : base(service, dto => dto.NTYPE_COMM) { }
}
