using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9200;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9200Controller : CrudApiController<TABLE9200Dto, CreateTABLE9200Dto, UpdateTABLE9200Dto, int>
{
    public TABLE9200Controller(ITABLE9200Service service) : base(service, dto => dto.NDATETYPE) { }
}
