using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5518;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5518Controller : CrudApiController<TABLE5518Dto, CreateTABLE5518Dto, UpdateTABLE5518Dto, int>
{
    public TABLE5518Controller(ITABLE5518Service service) : base(service, dto => dto.NNATIONALITY) { }
}
