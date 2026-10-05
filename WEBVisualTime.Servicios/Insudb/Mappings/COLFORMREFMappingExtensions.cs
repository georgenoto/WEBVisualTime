using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COLFORMREFMappingExtensions
{
    public static COLFORMREFDto ToDto(this COLFORMREF entity)
    {
        if (entity == null) return null!;
        return new COLFORMREFDto
        {
            NBORDEREAUX = entity.NBORDEREAUX,
            STYPE = entity.STYPE,
            NBANK = entity.NBANK,
            TABLE7SDESCRIPT = entity.TABLE7?.SDESCRIPT,
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            NREL_AMOUN = entity.NREL_AMOUN,
            NCURRENCY = entity.NCURRENCY,
            NPOLICY = entity.NPOLICY,
            DCOLLECT = entity.DCOLLECT,
            NBRANCH = entity.NBRANCH,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NPRODUCT = entity.NPRODUCT,
            SREL_TYPE = entity.SREL_TYPE,
            TABLE7502SDESCRIPT = entity.TABLE7502?.SDESCRIPT,
            SSTATUS = entity.SSTATUS,
            NCERTIF = entity.NCERTIF,
            SCONWIN = entity.SCONWIN,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NUSER_AMEND = entity.NUSER_AMEND,
            NCASHNUM = entity.NCASHNUM,
            NINPUTTYP = entity.NINPUTTYP,
            TABLE5554SDESCRIPT = entity.TABLE5554?.SDESCRIPT,
            NINSUR_AREA = entity.NINSUR_AREA,
            TABLE5001SDESCRIPT = entity.TABLE5001?.SDESCRIPT,
            NAGREEMENT = entity.NAGREEMENT,
            DVALUEDATE = entity.DVALUEDATE,
            SIND_ANNUITY = entity.SIND_ANNUITY,
            DDATE_BENLAR = entity.DDATE_BENLAR,
            NCOLLECTOR = entity.NCOLLECTOR,
            SRELORIGI = entity.SRELORIGI,
            DCOLLECTDATE = entity.DCOLLECTDATE,
            NBILLNUM = entity.NBILLNUM,
            NRETENTION = entity.NRETENTION,
            NTAXRETENTION = entity.NTAXRETENTION,
            NNULLCODE = entity.NNULLCODE,
            NNOTENUM = entity.NNOTENUM,
            NIMAGENUM = entity.NIMAGENUM,
        };
    }

    public static COLFORMREF ToEntity(this CreateCOLFORMREFDto dto)
    {
        if (dto == null) return null!;
        return new COLFORMREF
        {
            STYPE = dto.STYPE,
            NBANK = dto.NBANK,
            NINTERMED = dto.NINTERMED,
            NREL_AMOUN = dto.NREL_AMOUN,
            NCURRENCY = dto.NCURRENCY,
            NPOLICY = dto.NPOLICY,
            DCOLLECT = dto.DCOLLECT,
            NBRANCH = dto.NBRANCH,
            NOFFICE = dto.NOFFICE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NPRODUCT = dto.NPRODUCT,
            SREL_TYPE = dto.SREL_TYPE,
            SSTATUS = dto.SSTATUS,
            NCERTIF = dto.NCERTIF,
            SCONWIN = dto.SCONWIN,
            SCLIENT = dto.SCLIENT,
            NUSER_AMEND = dto.NUSER_AMEND,
            NCASHNUM = dto.NCASHNUM,
            NINPUTTYP = dto.NINPUTTYP,
            NINSUR_AREA = dto.NINSUR_AREA,
            NAGREEMENT = dto.NAGREEMENT,
            DVALUEDATE = dto.DVALUEDATE,
            SIND_ANNUITY = dto.SIND_ANNUITY,
            DDATE_BENLAR = dto.DDATE_BENLAR,
            NCOLLECTOR = dto.NCOLLECTOR,
            SRELORIGI = dto.SRELORIGI,
            DCOLLECTDATE = dto.DCOLLECTDATE,
            NBILLNUM = dto.NBILLNUM,
            NRETENTION = dto.NRETENTION,
            NTAXRETENTION = dto.NTAXRETENTION,
            NNULLCODE = dto.NNULLCODE,
            NNOTENUM = dto.NNOTENUM,
            NIMAGENUM = dto.NIMAGENUM,
        };
    }

    public static void UpdateEntity(this COLFORMREF entity, UpdateCOLFORMREFDto dto)
    {
        if (entity == null || dto == null) return;
        entity.STYPE = dto.STYPE;
        entity.NBANK = dto.NBANK;
        entity.NINTERMED = dto.NINTERMED;
        entity.NREL_AMOUN = dto.NREL_AMOUN;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NPOLICY = dto.NPOLICY;
        entity.DCOLLECT = dto.DCOLLECT;
        entity.NBRANCH = dto.NBRANCH;
        entity.NOFFICE = dto.NOFFICE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.SREL_TYPE = dto.SREL_TYPE;
        entity.SSTATUS = dto.SSTATUS;
        entity.NCERTIF = dto.NCERTIF;
        entity.SCONWIN = dto.SCONWIN;
        entity.SCLIENT = dto.SCLIENT;
        entity.NUSER_AMEND = dto.NUSER_AMEND;
        entity.NCASHNUM = dto.NCASHNUM;
        entity.NINPUTTYP = dto.NINPUTTYP;
        entity.NINSUR_AREA = dto.NINSUR_AREA;
        entity.NAGREEMENT = dto.NAGREEMENT;
        entity.DVALUEDATE = dto.DVALUEDATE;
        entity.SIND_ANNUITY = dto.SIND_ANNUITY;
        entity.DDATE_BENLAR = dto.DDATE_BENLAR;
        entity.NCOLLECTOR = dto.NCOLLECTOR;
        entity.SRELORIGI = dto.SRELORIGI;
        entity.DCOLLECTDATE = dto.DCOLLECTDATE;
        entity.NBILLNUM = dto.NBILLNUM;
        entity.NRETENTION = dto.NRETENTION;
        entity.NTAXRETENTION = dto.NTAXRETENTION;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NIMAGENUM = dto.NIMAGENUM;
    }
}
