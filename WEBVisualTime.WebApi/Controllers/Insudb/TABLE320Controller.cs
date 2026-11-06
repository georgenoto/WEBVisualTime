using WEBVisualTime.Servicios.Insudb.DTOs.TABLE320;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE320Controller : CrudApiController<TABLE320Dto, CreateTABLE320Dto, UpdateTABLE320Dto, int>
{
    public TABLE320Controller(ITABLE320Service service) : base(service, dto => dto.NOPERATOR) { }
}
