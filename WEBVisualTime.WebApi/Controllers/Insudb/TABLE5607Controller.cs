using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5607;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5607Controller : CrudApiController<TABLE5607Dto, CreateTABLE5607Dto, UpdateTABLE5607Dto, int>
{
    public TABLE5607Controller(ITABLE5607Service service) : base(service, dto => dto.NTABLETYP) { }
}
