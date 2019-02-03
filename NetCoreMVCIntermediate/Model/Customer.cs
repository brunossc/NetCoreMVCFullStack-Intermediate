using System.ComponentModel.DataAnnotations;

namespace NetCoreMVCIntermediate.Model
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(100,ErrorMessage = "Length must be in max. 100 chars.")]
        public string Name { get; set; }

        public bool NotActive { get; set; }
    }
}