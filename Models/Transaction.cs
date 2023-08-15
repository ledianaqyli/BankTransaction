using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransaction.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Acount Number")]
        [Required(ErrorMessage = "This is a field requried.")]
        [MaxLength(12,ErrorMessage ="Max 12 characters only")]
        public string AccountName { get; set; }
       
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This is a field requried.")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This is a field requried.")]
        public string BankName { get;set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This is a field requried.")]
        [MaxLength(11, ErrorMessage = "Max 11 characters only")]
        public string SwiftCode { get; set; }
        [Required(ErrorMessage = "This is a field requried.")]
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }
    }
}
