using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5569;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5569Controller : CrudApiController<TABLE5569Dto, CreateTABLE5569Dto, UpdateTABLE5569Dto, int>
{
    public TABLE5569Controller(ITABLE5569Service service) : base(service, dto => dto.NTYPEISSUE) { }
}
