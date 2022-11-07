using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product
    {
        public Product()
        {
            this.Tags = new HashSet<Tag>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime CreateDate { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public int TagId { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

    }
}
