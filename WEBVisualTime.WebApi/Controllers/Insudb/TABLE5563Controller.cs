using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5563;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5563Controller : CrudApiController<TABLE5563Dto, CreateTABLE5563Dto, UpdateTABLE5563Dto, int>
{
    public TABLE5563Controller(ITABLE5563Service service) : base(service, dto => dto.NCLASIFIC) { }
}
