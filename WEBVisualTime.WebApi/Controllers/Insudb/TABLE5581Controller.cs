using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5581;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5581Controller : CrudApiController<TABLE5581Dto, CreateTABLE5581Dto, UpdateTABLE5581Dto, int>
{
    public TABLE5581Controller(ITABLE5581Service service) : base(service, dto => dto.NTYPE_REC) { }
}
