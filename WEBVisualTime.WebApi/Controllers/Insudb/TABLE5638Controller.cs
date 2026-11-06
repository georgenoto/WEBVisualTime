using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5638;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5638Controller : CrudApiController<TABLE5638Dto, CreateTABLE5638Dto, UpdateTABLE5638Dto, int>
{
    public TABLE5638Controller(ITABLE5638Service service) : base(service, dto => dto.NCOMPANY) { }
}
