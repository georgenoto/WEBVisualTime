using WEBVisualTime.Servicios.Insudb.DTOs.TABLE3012;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE3012Controller : CrudApiController<TABLE3012Dto, CreateTABLE3012Dto, UpdateTABLE3012Dto, int>
{
    public TABLE3012Controller(ITABLE3012Service service) : base(service, dto => dto.NENDORSETYPE) { }
}
