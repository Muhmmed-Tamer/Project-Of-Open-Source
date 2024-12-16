using System.ComponentModel.DataAnnotations.Schema;

namespace Open_Source_Project.Models
{
    public class User_Table
    {
        public  ApplicationUser  ?User { get; set; }
        public Table ?Table{ get; set; }
        [ForeignKey("User")]
        public string ApplicationUserId {  get; set; }
        [ForeignKey("Table")]
        public int TableId {  get; set; }
        //Extra Data 
        public DateTime BookedTableAt { get; set; } = DateTime.Now;
        public DateTime ExpiredOfBookATable { get; set; } = DateTime.Now.AddMinutes(2);
    }
}
