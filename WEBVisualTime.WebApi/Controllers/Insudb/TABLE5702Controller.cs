using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5702;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5702Controller : CrudApiController<TABLE5702Dto, CreateTABLE5702Dto, UpdateTABLE5702Dto, int>
{
    public TABLE5702Controller(ITABLE5702Service service) : base(service, dto => dto.NFIELDTYPE) { }
}
