using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9014;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9014Controller : CrudApiController<TABLE9014Dto, CreateTABLE9014Dto, UpdateTABLE9014Dto, int>
{
    public TABLE9014Controller(ITABLE9014Service service) : base(service, dto => dto.NRISK) { }
}
