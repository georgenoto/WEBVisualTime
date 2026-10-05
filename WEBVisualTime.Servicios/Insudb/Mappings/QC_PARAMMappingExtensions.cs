using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.QC_PARAM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class QC_PARAMMappingExtensions
{
    public static QC_PARAMDto ToDto(this QC_PARAM entity)
    {
        if (entity == null) return null!;
        return new QC_PARAMDto
        {
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            NPRODUCT = entity.NPRODUCT,
            PRODMASTERSDESCRIPT = entity.PRODMASTER?.SDESCRIPT,
            SPOLITYPE = entity.SPOLITYPE,
            NCURRENCY = entity.NCURRENCY,
            TABLE11SDESCRIPT = entity.TABLE11?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            SINDQCOBL = entity.SINDQCOBL,
            NROUTY_QC = entity.NROUTY_QC,
            TABLE9105NROUTY_QCSDESCRIPT = entity.TABLE9105NROUTY_QC?.SDESCRIPT,
            SROUT_QC = entity.SROUT_QC,
            TAB_ROUTINESROUT_QCSDESCRIPT = entity.TAB_ROUTINESROUT_QC?.SDESCRIPT,
            NROUTY_QCCAP = entity.NROUTY_QCCAP,
            TABLE9105NROUTY_QCCAPSDESCRIPT = entity.TABLE9105NROUTY_QCCAP?.SDESCRIPT,
            SROUT_QCCAP = entity.SROUT_QCCAP,
            TAB_ROUTINESROUT_QCCAPSDESCRIPT = entity.TAB_ROUTINESROUT_QCCAP?.SDESCRIPT,
            NMINAGEQC = entity.NMINAGEQC,
            NCAPMINCC = entity.NCAPMINCC,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            SSTATREG = entity.SSTATREG,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
        };
    }

    public static QC_PARAM ToEntity(this CreateQC_PARAMDto dto)
    {
        if (dto == null) return null!;
        return new QC_PARAM
        {
            SINDQCOBL = dto.SINDQCOBL,
            NROUTY_QC = dto.NROUTY_QC,
            SROUT_QC = dto.SROUT_QC,
            NROUTY_QCCAP = dto.NROUTY_QCCAP,
            SROUT_QCCAP = dto.SROUT_QCCAP,
            NMINAGEQC = dto.NMINAGEQC,
            NCAPMINCC = dto.NCAPMINCC,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            SSTATREG = dto.SSTATREG,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this QC_PARAM entity, UpdateQC_PARAMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SINDQCOBL = dto.SINDQCOBL;
        entity.NROUTY_QC = dto.NROUTY_QC;
        entity.SROUT_QC = dto.SROUT_QC;
        entity.NROUTY_QCCAP = dto.NROUTY_QCCAP;
        entity.SROUT_QCCAP = dto.SROUT_QCCAP;
        entity.NMINAGEQC = dto.NMINAGEQC;
        entity.NCAPMINCC = dto.NCAPMINCC;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SSTATREG = dto.SSTATREG;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
