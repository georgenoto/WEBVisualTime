using WEBVisualTime.Servicios.Insudb.DTOs.H_ASSIGNMENT_PART;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class H_ASSIGNMENT_PARTController : CatalogController<H_ASSIGNMENT_PARTDto, CreateH_ASSIGNMENT_PARTDto, UpdateH_ASSIGNMENT_PARTDto, long>
{
    public H_ASSIGNMENT_PARTController(IH_ASSIGNMENT_PARTService service)
        : base(service, "H_ASSIGNMENT_PART", "NID_NUMREG", new[] { "NID_NUMREG", "NINSUR_AREA", "NINTERTYP", "NTYPE_ASSIGN", "DATE_ASSIG_INI", "DATE_ASSIG_END", "NINTERMED", "NTEMPASSI", "STEMPASSI", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
