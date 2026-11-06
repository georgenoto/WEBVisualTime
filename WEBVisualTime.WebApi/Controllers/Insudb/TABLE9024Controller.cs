using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9024;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9024Controller : CrudApiController<TABLE9024Dto, CreateTABLE9024Dto, UpdateTABLE9024Dto, int>
{
    public TABLE9024Controller(ITABLE9024Service service) : base(service, dto => dto.NLIQACD) { }
}
