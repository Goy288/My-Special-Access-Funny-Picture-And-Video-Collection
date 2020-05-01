using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Special_Access_Funny_Picture_And_Video_Collection.Models
{
    public class Media
    {
        private static readonly string[] VideoTypes = new string[] { "mp4", "webm", "ogg" };
        private static readonly string[] ImageTypes = new string[] { "jpeg", "jpg", "png", "gif" };

        [Key]
        public int MediaID { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(260)")]
        [StringLength(260)]
        public string FileName { get; set; }

        [Required]
        [StringLength(64)]
        public string FileType { get; set; }

        [Required]
        public bool IsVideo { get; set; }

        public Media(string fileName)
        {
            string[] fileNamePieces = fileName.Split('.');

            FileName = fileNamePieces[0];
            FileType = fileNamePieces[1].ToLower();

            IsVideo = false;
            foreach (string videoType in VideoTypes)
            {
                if (videoType == FileType)
                {
                    IsVideo = true;
                    break;
                }
            }
            if (!IsVideo)
            {
                bool isAnyType = false;
                foreach (string imageType in ImageTypes)
                {
                    if (imageType == FileType)
                    {
                        isAnyType = true;
                        break;
                    }
                }
                if (!isAnyType)
                {
                    throw new ArgumentException("This file type is not compatible.");
                }
            }
        }
        public Media() { }

        public string GetFileUrl()
        {
            string url = "/meme/";
            url += IsVideo ? "vid/" : "img/";
            url += FileName + "." + FileType;
            return url;
        }
    }
}
