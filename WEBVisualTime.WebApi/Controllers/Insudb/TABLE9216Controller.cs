using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9216;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9216Controller : CrudApiController<TABLE9216Dto, CreateTABLE9216Dto, UpdateTABLE9216Dto, int>
{
    public TABLE9216Controller(ITABLE9216Service service) : base(service, dto => dto.NMEDICALSTAT) { }
}
