using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9212;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9212Controller : CrudApiController<TABLE9212Dto, CreateTABLE9212Dto, UpdateTABLE9212Dto, int>
{
    public TABLE9212Controller(ITABLE9212Service service) : base(service, dto => dto.NCLAIMANTTYPE) { }
}
