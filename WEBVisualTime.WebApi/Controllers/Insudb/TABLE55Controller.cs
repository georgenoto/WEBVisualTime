using WEBVisualTime.Servicios.Insudb.DTOs.TABLE55;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE55Controller : CrudApiController<TABLE55Dto, CreateTABLE55Dto, UpdateTABLE55Dto, int>
{
    public TABLE55Controller(ITABLE55Service service) : base(service, dto => dto.NRELATION) { }
}
