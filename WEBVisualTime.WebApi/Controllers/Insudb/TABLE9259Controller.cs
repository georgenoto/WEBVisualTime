using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9259;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9259Controller : CrudApiController<TABLE9259Dto, CreateTABLE9259Dto, UpdateTABLE9259Dto, int>
{
    public TABLE9259Controller(ITABLE9259Service service) : base(service, dto => dto.NCATEG_PROV) { }
}
