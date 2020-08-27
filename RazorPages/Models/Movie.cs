using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        // Day la attribute: voi truong hop nay nguoi dung khong can nhap thong tin thoi gian
        // Chi ngay duoc hien thi, khong bao gom thoi gian
        // Tham khao DataAnnotations: https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=netcore-3.1
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } // Ngay phat hanh
        public string Genre { get; set; }   // The loai
        public decimal Price { get; set; }
    }
}
