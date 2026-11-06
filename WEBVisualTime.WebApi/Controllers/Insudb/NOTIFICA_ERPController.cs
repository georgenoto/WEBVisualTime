using WEBVisualTime.Servicios.Insudb.DTOs.NOTIFICA_ERP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class NOTIFICA_ERPController : CrudApiController<NOTIFICA_ERPDto, CreateNOTIFICA_ERPDto, UpdateNOTIFICA_ERPDto, string>
{
    public NOTIFICA_ERPController(INOTIFICA_ERPService service) : base(service, dto => dto.SKEY) { }
}
