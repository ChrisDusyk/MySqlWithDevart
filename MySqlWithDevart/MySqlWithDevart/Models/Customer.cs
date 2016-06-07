using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySqlWithDevart.Models
{
	[Table("Customers")]
	public partial class Customer
	{
		public int CustomerId { get; set; }

		[Required]
		[StringLength(200)]
		public string CustomerName { get; set; }

		public DateTime CreatedDate { get; set; }
	}
}