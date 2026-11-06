using WEBVisualTime.Servicios.Insudb.DTOs.TABLE340;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE340Controller : CrudApiController<TABLE340Dto, CreateTABLE340Dto, UpdateTABLE340Dto, int>
{
    public TABLE340Controller(ITABLE340Service service) : base(service, dto => dto.NFREQMAXEVEN) { }
}
