using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Task17.Models
{
    public class DataClass
    {
        public long FirstNumber { get; set; }
        public long SecondNumber { get; set; }
        [Display(Name = "Choose Operation")]
        public List<OperationList>? Operations { get; set; }
        public int SelectedOperation { get; set; }
    }

    public class OperationList
    {
        public string? OperationId { get; set; }
        public string? Operation { get; set; }
    }
}