using WEBVisualTime.Servicios.Insudb.DTOs.NOTIFICA_ERP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class NOTIFICA_ERPController : CatalogController<NOTIFICA_ERPDto, CreateNOTIFICA_ERPDto, UpdateNOTIFICA_ERPDto, string>
{
    public NOTIFICA_ERPController(INOTIFICA_ERPService service)
        : base(service, "NOTIFICA_ERP", "SKEY", new[] { "SPROCESO", "SKEY", "SESTADO", "DFECHA_PROCESO", "DCOMPDATE", "NUSERCODE", "DOPERDATE" }) { }
}
