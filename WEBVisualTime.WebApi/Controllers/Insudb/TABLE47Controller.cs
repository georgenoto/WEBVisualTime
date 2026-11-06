using WEBVisualTime.Servicios.Insudb.DTOs.TABLE47;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE47Controller : CrudApiController<TABLE47Dto, CreateTABLE47Dto, UpdateTABLE47Dto, string>
{
    public TABLE47Controller(ITABLE47Service service) : base(service, dto => dto.SCOMMITYP) { }
}
