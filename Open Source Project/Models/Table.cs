using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace Open_Source_Project.Models
{
    public class Table
    {
        public int Id { get; set; }
        [DisplayName("Table Name")]
        public string TableName{ get; set; }
        [Range(1, 4)]
        public int Capacity { get; set; }
        public string Status { get; set; }       
        public ICollection<User_Table>? User_Tables { get; set; }
    }
}
