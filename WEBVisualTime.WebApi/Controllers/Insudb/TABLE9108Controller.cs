using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9108;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9108Controller : CrudApiController<TABLE9108Dto, CreateTABLE9108Dto, UpdateTABLE9108Dto, int>
{
    public TABLE9108Controller(ITABLE9108Service service) : base(service, dto => dto.NTYPE_CONTRAT) { }
}
