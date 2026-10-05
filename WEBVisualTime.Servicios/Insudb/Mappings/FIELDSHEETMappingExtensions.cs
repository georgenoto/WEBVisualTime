using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FIELDSHEET;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class FIELDSHEETMappingExtensions
{
    public static FIELDSHEETDto ToDto(this FIELDSHEET entity)
    {
        if (entity == null) return null!;
        return new FIELDSHEETDto
        {
            NSHEET = entity.NSHEET,
            NFIELD = entity.NFIELD,
            DCOMPDATE = entity.DCOMPDATE,
            NFIELDTYPE = entity.NFIELDTYPE,
            STABLE = entity.STABLE,
            NUSERCODE = entity.NUSERCODE,
            SFIELDDESC = entity.SFIELDDESC,
            SCOLUMNNAME = entity.SCOLUMNNAME,
            SVALUE = entity.SVALUE,
            SRUTINE = entity.SRUTINE,
            NROWORDER = entity.NROWORDER,
            NFIELDORDER = entity.NFIELDORDER,
            SVALUESLIST = entity.SVALUESLIST,
            NFIELDLARGE = entity.NFIELDLARGE,
            NOBJTYPE = entity.NOBJTYPE,
            NTABLEHOMO = entity.NTABLEHOMO,
            NOPERATOR = entity.NOPERATOR,
            NCONDIT = entity.NCONDIT,
            SFIELDCOMMEN = entity.SFIELDCOMMEN,
            SFIELDREL = entity.SFIELDREL,
            SOBLIGATORY = entity.SOBLIGATORY,
            SLASTMOVE = entity.SLASTMOVE,
            NDATATYPE = entity.NDATATYPE,
            SRPARENTH = entity.SRPARENTH,
            SLPARENTH = entity.SLPARENTH,
            NDECIMAL = entity.NDECIMAL,
            SREPORT = entity.SREPORT,
            LPADVAR = entity.LPADVAR,
            RPADVAR = entity.RPADVAR,
            NLEVEL = entity.NLEVEL,
            NCRITER_ORDER = entity.NCRITER_ORDER,
            NDEFTYPE = entity.NDEFTYPE,
            NIDREC = entity.NIDREC,
            SDESCRIPT = entity.SDESCRIPT,
            SUPDATEIND = entity.SUPDATEIND,
        };
    }

    public static FIELDSHEET ToEntity(this CreateFIELDSHEETDto dto)
    {
        if (dto == null) return null!;
        return new FIELDSHEET
        {
            DCOMPDATE = dto.DCOMPDATE,
            NFIELDTYPE = dto.NFIELDTYPE,
            STABLE = dto.STABLE,
            NUSERCODE = dto.NUSERCODE,
            SFIELDDESC = dto.SFIELDDESC,
            SCOLUMNNAME = dto.SCOLUMNNAME,
            SVALUE = dto.SVALUE,
            SRUTINE = dto.SRUTINE,
            NROWORDER = dto.NROWORDER,
            NFIELDORDER = dto.NFIELDORDER,
            SVALUESLIST = dto.SVALUESLIST,
            NFIELDLARGE = dto.NFIELDLARGE,
            NOBJTYPE = dto.NOBJTYPE,
            NTABLEHOMO = dto.NTABLEHOMO,
            NOPERATOR = dto.NOPERATOR,
            NCONDIT = dto.NCONDIT,
            SFIELDCOMMEN = dto.SFIELDCOMMEN,
            SFIELDREL = dto.SFIELDREL,
            SOBLIGATORY = dto.SOBLIGATORY,
            SLASTMOVE = dto.SLASTMOVE,
            NDATATYPE = dto.NDATATYPE,
            SRPARENTH = dto.SRPARENTH,
            SLPARENTH = dto.SLPARENTH,
            NDECIMAL = dto.NDECIMAL,
            SREPORT = dto.SREPORT,
            LPADVAR = dto.LPADVAR,
            RPADVAR = dto.RPADVAR,
            NLEVEL = dto.NLEVEL,
            NCRITER_ORDER = dto.NCRITER_ORDER,
            NDEFTYPE = dto.NDEFTYPE,
            NIDREC = dto.NIDREC,
            SDESCRIPT = dto.SDESCRIPT,
            SUPDATEIND = dto.SUPDATEIND,
        };
    }

    public static void UpdateEntity(this FIELDSHEET entity, UpdateFIELDSHEETDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NFIELDTYPE = dto.NFIELDTYPE;
        entity.STABLE = dto.STABLE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SFIELDDESC = dto.SFIELDDESC;
        entity.SCOLUMNNAME = dto.SCOLUMNNAME;
        entity.SVALUE = dto.SVALUE;
        entity.SRUTINE = dto.SRUTINE;
        entity.NROWORDER = dto.NROWORDER;
        entity.NFIELDORDER = dto.NFIELDORDER;
        entity.SVALUESLIST = dto.SVALUESLIST;
        entity.NFIELDLARGE = dto.NFIELDLARGE;
        entity.NOBJTYPE = dto.NOBJTYPE;
        entity.NTABLEHOMO = dto.NTABLEHOMO;
        entity.NOPERATOR = dto.NOPERATOR;
        entity.NCONDIT = dto.NCONDIT;
        entity.SFIELDCOMMEN = dto.SFIELDCOMMEN;
        entity.SFIELDREL = dto.SFIELDREL;
        entity.SOBLIGATORY = dto.SOBLIGATORY;
        entity.SLASTMOVE = dto.SLASTMOVE;
        entity.NDATATYPE = dto.NDATATYPE;
        entity.SRPARENTH = dto.SRPARENTH;
        entity.SLPARENTH = dto.SLPARENTH;
        entity.NDECIMAL = dto.NDECIMAL;
        entity.SREPORT = dto.SREPORT;
        entity.LPADVAR = dto.LPADVAR;
        entity.RPADVAR = dto.RPADVAR;
        entity.NLEVEL = dto.NLEVEL;
        entity.NCRITER_ORDER = dto.NCRITER_ORDER;
        entity.NDEFTYPE = dto.NDEFTYPE;
        entity.NIDREC = dto.NIDREC;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SUPDATEIND = dto.SUPDATEIND;
    }
}
