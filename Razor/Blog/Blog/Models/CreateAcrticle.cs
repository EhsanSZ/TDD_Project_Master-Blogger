using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class CreateArticle
    {
        [DisplayName("عنوان")]
        [Required(ErrorMessage = "عنوان مقاله اجباری است")]
        public string Title { get; set; }
        [DisplayName("مسیر عکس")]
        [Required(ErrorMessage = "عکس مقاله اجباری است")]
        public string Picture { get; set; }
        [DisplayName("Alt عکس")]
        public string PictureAlt { get; set; }
        [DisplayName("عنوان عکس")]
        public string PictureTitle { get; set; }
        [DisplayName("توضیحات کوتاه")]
        [Required(ErrorMessage = "توضیحات کوتاه مقاله اجباری است")]
        public string ShortDescription { get; set; }
        [DisplayName("متن مقاله")]
        public string Body { get; set; }
    }
}
