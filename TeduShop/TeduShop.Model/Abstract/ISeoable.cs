using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public interface ISeoable
    {
        [MaxLength(256)]
        string MetaKeyword { get; set; }

        [MaxLength(256)]
        string MetaDescription { get; set; }
    }
}