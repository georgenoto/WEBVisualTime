using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9223;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9223Controller : CrudApiController<TABLE9223Dto, CreateTABLE9223Dto, UpdateTABLE9223Dto, int>
{
    public TABLE9223Controller(ITABLE9223Service service) : base(service, dto => dto.NCLASSIFICATION) { }
}
