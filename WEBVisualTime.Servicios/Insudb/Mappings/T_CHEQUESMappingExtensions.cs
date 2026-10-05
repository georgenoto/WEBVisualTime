using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_CHEQUES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class T_CHEQUESMappingExtensions
{
    public static T_CHEQUESDto ToDto(this T_CHEQUES entity)
    {
        if (entity == null) return null!;
        return new T_CHEQUESDto
        {
            NBORDEREAUX = entity.NBORDEREAUX,
            COLFORMREFSTYPE = entity.COLFORMREF?.STYPE,
            NSEQUENCE = entity.NSEQUENCE,
            NREQUEST_NU = entity.NREQUEST_NU,
            SCHEQUE = entity.SCHEQUE,
            NAMOUNT = entity.NAMOUNT,
            SCLIENT = entity.SCLIENT,
            DDAT_PROPOS = entity.DDAT_PROPOS,
            SREQUEST_TY = entity.SREQUEST_TY,
            NACC_BANK = entity.NACC_BANK,
            NCURRENCY = entity.NCURRENCY,
            NCONSEC = entity.NCONSEC,
            NCONCEPT = entity.NCONCEPT,
            NBRANCH_LED = entity.NBRANCH_LED,
            NCLAIM = entity.NCLAIM,
            DCOMPDATE = entity.DCOMPDATE,
            NVOUCHER_LE = entity.NVOUCHER_LE,
            NVOUCHER = entity.NVOUCHER,
            SDESCRIPT = entity.SDESCRIPT,
            DISSUE_DAT = entity.DISSUE_DAT,
            DLEDGER_DAT = entity.DLEDGER_DAT,
            NNULLCODE = entity.NNULLCODE,
            DNULLDATE = entity.DNULLDATE,
            SPAY_FREQ = entity.SPAY_FREQ,
            NQ_PAYS = entity.NQ_PAYS,
            NRECEIPT = entity.NRECEIPT,
            NSTA_CHEQUE = entity.NSTA_CHEQUE,
            DSTAT_DATE = entity.DSTAT_DATE,
            NTRANSAC = entity.NTRANSAC,
            NUSER_SOL = entity.NUSER_SOL,
            NUSERCODE = entity.NUSERCODE,
            NYEAR_MONTH = entity.NYEAR_MONTH,
            NNOTENUM = entity.NNOTENUM,
            NAFECT = entity.NAFECT,
            NEXENT = entity.NEXENT,
            NTAXCODE = entity.NTAXCODE,
            NTAX_AMOUNT = entity.NTAX_AMOUNT,
            NOFFICE = entity.NOFFICE,
            NCASHNUM = entity.NCASHNUM,
            NINSUR_AREA = entity.NINSUR_AREA,
            NPAYORDBORD = entity.NPAYORDBORD,
            NCOMPANY = entity.NCOMPANY,
            SINTER_PAY = entity.SINTER_PAY,
            NAMOUNT_LOCAL = entity.NAMOUNT_LOCAL,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            SFILE_FIN700 = entity.SFILE_FIN700,
            DDATE_FIN700 = entity.DDATE_FIN700,
            NTYPESUPPORT = entity.NTYPESUPPORT,
            NDOCSUPPORT = entity.NDOCSUPPORT,
            NTAX_PERCENT = entity.NTAX_PERCENT,
            NCURRENCYORI = entity.NCURRENCYORI,
            NCURRENCY_PAY = entity.NCURRENCY_PAY,
            NAMOUNTPAY = entity.NAMOUNTPAY,
            DPOSTED = entity.DPOSTED,
            NOFFICEAGEN = entity.NOFFICEAGEN,
            NAGENCY = entity.NAGENCY,
            SACTION = entity.SACTION,
        };
    }

    public static T_CHEQUES ToEntity(this CreateT_CHEQUESDto dto)
    {
        if (dto == null) return null!;
        return new T_CHEQUES
        {
            NREQUEST_NU = dto.NREQUEST_NU,
            SCHEQUE = dto.SCHEQUE,
            NAMOUNT = dto.NAMOUNT,
            SCLIENT = dto.SCLIENT,
            DDAT_PROPOS = dto.DDAT_PROPOS,
            SREQUEST_TY = dto.SREQUEST_TY,
            NACC_BANK = dto.NACC_BANK,
            NCURRENCY = dto.NCURRENCY,
            NCONSEC = dto.NCONSEC,
            NCONCEPT = dto.NCONCEPT,
            NBRANCH_LED = dto.NBRANCH_LED,
            NCLAIM = dto.NCLAIM,
            DCOMPDATE = dto.DCOMPDATE,
            NVOUCHER_LE = dto.NVOUCHER_LE,
            NVOUCHER = dto.NVOUCHER,
            SDESCRIPT = dto.SDESCRIPT,
            DISSUE_DAT = dto.DISSUE_DAT,
            DLEDGER_DAT = dto.DLEDGER_DAT,
            NNULLCODE = dto.NNULLCODE,
            DNULLDATE = dto.DNULLDATE,
            SPAY_FREQ = dto.SPAY_FREQ,
            NQ_PAYS = dto.NQ_PAYS,
            NRECEIPT = dto.NRECEIPT,
            NSTA_CHEQUE = dto.NSTA_CHEQUE,
            DSTAT_DATE = dto.DSTAT_DATE,
            NTRANSAC = dto.NTRANSAC,
            NUSER_SOL = dto.NUSER_SOL,
            NUSERCODE = dto.NUSERCODE,
            NYEAR_MONTH = dto.NYEAR_MONTH,
            NNOTENUM = dto.NNOTENUM,
            NAFECT = dto.NAFECT,
            NEXENT = dto.NEXENT,
            NTAXCODE = dto.NTAXCODE,
            NTAX_AMOUNT = dto.NTAX_AMOUNT,
            NOFFICE = dto.NOFFICE,
            NCASHNUM = dto.NCASHNUM,
            NINSUR_AREA = dto.NINSUR_AREA,
            NPAYORDBORD = dto.NPAYORDBORD,
            NCOMPANY = dto.NCOMPANY,
            SINTER_PAY = dto.SINTER_PAY,
            NAMOUNT_LOCAL = dto.NAMOUNT_LOCAL,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            SFILE_FIN700 = dto.SFILE_FIN700,
            DDATE_FIN700 = dto.DDATE_FIN700,
            NTYPESUPPORT = dto.NTYPESUPPORT,
            NDOCSUPPORT = dto.NDOCSUPPORT,
            NTAX_PERCENT = dto.NTAX_PERCENT,
            NCURRENCYORI = dto.NCURRENCYORI,
            NCURRENCY_PAY = dto.NCURRENCY_PAY,
            NAMOUNTPAY = dto.NAMOUNTPAY,
            DPOSTED = dto.DPOSTED,
            NOFFICEAGEN = dto.NOFFICEAGEN,
            NAGENCY = dto.NAGENCY,
            SACTION = dto.SACTION,
        };
    }

    public static void UpdateEntity(this T_CHEQUES entity, UpdateT_CHEQUESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NREQUEST_NU = dto.NREQUEST_NU;
        entity.SCHEQUE = dto.SCHEQUE;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.SCLIENT = dto.SCLIENT;
        entity.DDAT_PROPOS = dto.DDAT_PROPOS;
        entity.SREQUEST_TY = dto.SREQUEST_TY;
        entity.NACC_BANK = dto.NACC_BANK;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NCONSEC = dto.NCONSEC;
        entity.NCONCEPT = dto.NCONCEPT;
        entity.NBRANCH_LED = dto.NBRANCH_LED;
        entity.NCLAIM = dto.NCLAIM;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NVOUCHER_LE = dto.NVOUCHER_LE;
        entity.NVOUCHER = dto.NVOUCHER;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.DISSUE_DAT = dto.DISSUE_DAT;
        entity.DLEDGER_DAT = dto.DLEDGER_DAT;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SPAY_FREQ = dto.SPAY_FREQ;
        entity.NQ_PAYS = dto.NQ_PAYS;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NSTA_CHEQUE = dto.NSTA_CHEQUE;
        entity.DSTAT_DATE = dto.DSTAT_DATE;
        entity.NTRANSAC = dto.NTRANSAC;
        entity.NUSER_SOL = dto.NUSER_SOL;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NYEAR_MONTH = dto.NYEAR_MONTH;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NAFECT = dto.NAFECT;
        entity.NEXENT = dto.NEXENT;
        entity.NTAXCODE = dto.NTAXCODE;
        entity.NTAX_AMOUNT = dto.NTAX_AMOUNT;
        entity.NOFFICE = dto.NOFFICE;
        entity.NCASHNUM = dto.NCASHNUM;
        entity.NINSUR_AREA = dto.NINSUR_AREA;
        entity.NPAYORDBORD = dto.NPAYORDBORD;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.SINTER_PAY = dto.SINTER_PAY;
        entity.NAMOUNT_LOCAL = dto.NAMOUNT_LOCAL;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.SFILE_FIN700 = dto.SFILE_FIN700;
        entity.DDATE_FIN700 = dto.DDATE_FIN700;
        entity.NTYPESUPPORT = dto.NTYPESUPPORT;
        entity.NDOCSUPPORT = dto.NDOCSUPPORT;
        entity.NTAX_PERCENT = dto.NTAX_PERCENT;
        entity.NCURRENCYORI = dto.NCURRENCYORI;
        entity.NCURRENCY_PAY = dto.NCURRENCY_PAY;
        entity.NAMOUNTPAY = dto.NAMOUNTPAY;
        entity.DPOSTED = dto.DPOSTED;
        entity.NOFFICEAGEN = dto.NOFFICEAGEN;
        entity.NAGENCY = dto.NAGENCY;
        entity.SACTION = dto.SACTION;
    }
}
