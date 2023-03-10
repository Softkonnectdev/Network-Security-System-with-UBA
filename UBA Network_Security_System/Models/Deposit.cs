using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UBA_Network_Security_System.Models
{
    public class Deposit : BaseEntity
    {
        [Required(ErrorMessage = "Account Number is NULL")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Account Number")]
        [StringLength(10, ErrorMessage = "Not more than 10 characters!")]
        [Display(Name = "Account Number")]
        public string AccountNumber
        {
            get; set;
        }
        [Required(ErrorMessage = "Account Name is NULL!")]
        [Display(Name = "Account Name")]
        public string AccountName
        {
            get; set;
        }
        [Required(ErrorMessage = "Amount is NULL!")]
        [DataType(DataType.Currency, ErrorMessage = "Not valid currency value")]
        public decimal Amount
        {
            get; set;
        }
        [Required(ErrorMessage = "Status is NULL!")]
        public bool Status
        {
            get; set;
        }
        [Required(ErrorMessage = "Remark is NULL!")]
        public string Remark
        {
            get; set;
        }
        [Required(ErrorMessage = "Depositor Name is NULL!")]
        [Display(Name = "Depositor Name")]
        public string DepositorName
        {
            get; set;
        }
        [Required(ErrorMessage = "DepositorPhone is NULL!")]
        [Display(Name = "Phone Number")]
        public string DepositorPhone
        {
            get; set;
        }
        [Required(ErrorMessage = "Cashier is NULL!")]
        [ForeignKey("Employee")]
        public string CashaierID
        {
            get; set;
        }

        [Required(ErrorMessage = "Account ID is NULL!")]
        [ForeignKey("Account")]
        public string AccountID
        {
            get; set;
        }

        public virtual Account Account { get; set; }
        public virtual Employee Employee { get; set; }
    }
}