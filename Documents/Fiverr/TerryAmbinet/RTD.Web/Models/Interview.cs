using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTD.Web.Models
{
    [Table("interview")]
    public class Interview
    {
        public int InterviewId { get; set; }
        public string EmpId { get; set; }
        public DateTime InterviewDate { get; set; } = DateTime.Now;
        public bool Completed { get; set; }
        public string S1EmpName { get; set; }
        public string S1AssignNo { get; set; }
        public int S1JobId { get; set; }
        public int S1DeptId { get; set; }
        public string S1ConHours { get; set; }
        public int S1WeekdayShift { get; set; }//tinyint
        public int S1WeekendShift { get; set; }//tinyint
        public int S1Sicknessid { get; set; }//tinyint
        public string S1SickneesInfo { get; set; }
        public string S1Abstart { get; set; }
        public string S1Abend { get; set; }
        public string S1Returndate { get; set; }
        public bool S1AbLenghtSt { get; set; }
        public bool S1AbLenghtLt { get; set; }
        public string S1Conhoursst { get; set; }
        public string S1Conhourslt { get; set; }
        public string S1Ex1 { get; set; }
        public string S1Ex2 { get; set; }
        public string S1Ex3 { get; set; }
        public string S2Street { get; set; }
        public string S2Area { get; set; }
        public string S2Town { get; set; }
        public string S2Postcode { get; set; }
        public string S2Mobile { get; set; }
        public string S2Landline { get; set; }
        public string S2Extra1 { get; set; }
        public bool S3Warning { get; set; }
        public int S3Stage { get; set; }
        public int S3Comp1 { get; set; }
        public int S3Comp2 { get; set; }
        public int S3Comp3 { get; set; }
        public int S3Comp4 { get; set; }
        public string S3Info { get; set; }
        public string S3Extra1 { get; set; }
        public string S3Extra2 { get; set; }
        public string S3Extre3 { get; set; }
        public bool S4Recovery { get; set; }
        public string S4Recoveryinfo { get; set; }
        public int S4Phase { get; set; }
        public bool S4Adjust { get; set; }
        public string S4Adjustinfo { get; set; }
        public string S4Extra1 { get; set; }
        public string S4Extra2 { get; set; }
        public bool S5Normal { get; set; }
        public bool S5Gp { get; set; }
        public bool S5Support { get; set; }
        public string S5Supportinfo { get; set; }
        public bool S5Med { get; set; }
        public bool S5Help { get; set; }
        public string S5Helpinfo { get; set; }
        public bool S5Stree { get; set; }
        public bool S5Personal { get; set; }
        public bool S5Wellbeing { get; set; }
        public bool S5Access { get; set; }
        public bool S5Useful { get; set; }
        public bool S5Resouce { get; set; }
        public bool S5Claim { get; set; }
        public bool S5Incident { get; set; }
        public bool S5Form { get; set; }
        public bool S5Risk { get; set; }
        public string S5Summary { get; set; }
        public bool S5Policy { get; set; }
        public bool S5Next { get; set; }
        public string S5NextInfo { get; set; }
        public bool S5Trade { get; set; }
        public string S5TradeInfo { get; set; }
        public string S5Extra1 { get; set; }
        public string S5Extar2 { get; set; }
        public string S5Extra3 { get; set; }
        public string S5Extra4 { get; set; }
        public bool S6Training { get; set; }
        public string S6TrainingInfo { get; set; }
        public bool S6appr { get; set; }
        public string S6ApprInfo { get; set; }
        public bool S6Esrabs { get; set; }
        public string S6EsrabsInfo { get; set; }
        public bool S6Esrwork { get; set; }
        public string S6EsrworkInfo { get; set; }
        public string S6Extra1 { get; set; }
        public string S6Extra2 { get; set; }
        public string S7Manager { get; set; }
        public string S7MDate { get; set; }
        public bool S7MsignBit { get; set; }
        public string S7Edate { get; set; }
        public bool S7EsignBit { get; set; }
        public byte[] S7MsignDigital { get; set; }//image
        public byte[] S7EsignDigital { get; set; }//image

        [NotMapped]
        public bool IsSaved { get; set; }
        [NotMapped]
        public string Message { get; set; }
    }
}
