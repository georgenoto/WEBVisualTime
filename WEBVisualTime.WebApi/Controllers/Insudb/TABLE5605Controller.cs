using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5605;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5605Controller : CrudApiController<TABLE5605Dto, CreateTABLE5605Dto, UpdateTABLE5605Dto, int>
{
    public TABLE5605Controller(ITABLE5605Service service) : base(service, dto => dto.NDOC_TYPE) { }
}
