using WEBVisualTime.Servicios.Insudb.DTOs.PROPERTYLIBRARY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PROPERTYLIBRARYController : CatalogController<PROPERTYLIBRARYDto, CreatePROPERTYLIBRARYDto, UpdatePROPERTYLIBRARYDto, int>
{
    public PROPERTYLIBRARYController(IPROPERTYLIBRARYService service)
        : base(service, "PROPERTYLIBRARY", "NIDPROPERTY", new[] { "NIDPROPERTY", "SPROPERTY", "SFORMAT", "DCOMPDATE", "NUSERCODE" }) { }
}
