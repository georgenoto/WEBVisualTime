using WEBVisualTime.Servicios.Insudb.DTOs.TABLE192;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE192Controller : CrudApiController<TABLE192Dto, CreateTABLE192Dto, UpdateTABLE192Dto, int>
{
    public TABLE192Controller(ITABLE192Service service) : base(service, dto => dto.NCL_SEQ_TRA) { }
}
