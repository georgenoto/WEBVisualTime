using WEBVisualTime.Servicios.Insudb.DTOs.TABLE211;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE211Controller : CrudApiController<TABLE211Dto, CreateTABLE211Dto, UpdateTABLE211Dto, int>
{
    public TABLE211Controller(ITABLE211Service service) : base(service, dto => dto.NIN_LIF_TYP) { }
}
