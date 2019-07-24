using ProjectManagement.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectManagement.Entity
{
    public class Sample
    {
        public int SampleId { get; set; }

        [Required(ErrorMessage = "Müşteri giriniz. ")]
        public string Customer { get; set; }

        [Required(ErrorMessage = "Talep No giriniz. ")]
        public string RequestNo { get; set; }

        [Required(ErrorMessage = "Beden Seçiniz.")]
        public string Size { get; set; }

        [EnumDataType(typeof(State))]
        [Required(ErrorMessage = "Durum Seçiniz.")]
        public State SampleState { get; set; }

        [Required(ErrorMessage = "Numune Tipi giriniz.")]
        public string SampleType { get; set; }


        [Required(ErrorMessage = "Talep Geliş Tarihini giriniz.")]
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime RequestDate { get; set; }

        [Required(ErrorMessage = "Çalışan seçiniz")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Required(ErrorMessage = "Termin Tarihini giriniz.")]
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Termin { get; set; }

        [Required(ErrorMessage = "Artikel giriniz.")]
        public string Artikel { get; set; }

        [Required(ErrorMessage = "Müşteri Model Numarasını giriniz.")]
        public string CustomerModelNo { get; set; }

        [Required(ErrorMessage = "Renk giriniz.")]
        public string Color { get; set; }

        [Required(ErrorMessage = "İstek adeti giriniz.")]
        public int RequestedCount { get; set; }
        
        public string ModelDescription { get; set; }
        
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? AccessoryOrderDate { get; set; }


        public string AccessoryTermin { get; set; }

       
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? MeshFinishDate { get; set; }

        
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? PaintDeliveryDate { get; set; }

        
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? PaintFinishDate { get; set; }
        
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? SewingFinishDate { get; set; }

        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? DeliveryDate { get; set; }

        public string DelayDescription { get; set; }
        public string DeliveryTime { get; set; }  //otomatik hesaplansın (temrin-geliş)= 
    }
}
