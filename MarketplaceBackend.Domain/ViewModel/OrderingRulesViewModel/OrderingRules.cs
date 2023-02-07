using System.ComponentModel.DataAnnotations;

namespace MarketplaceBackend.Domain.ViewModel.OrderingRulesViewModel
{
    public class OrderingRules
    {
        [Required(ErrorMessage = "Вы не указали ФИО")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Вы не указали улицу")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Вы не указали номер дома")]
        public string HouseNumber { get; set; }
        [Required(ErrorMessage = "Вы не указали номер квартиры")]
        public string ApartmentNumber { get; set; }

        /* public int? MinQuantity { get; set; }
         public decimal? MinTotalSum { get; set; }*/
    }
}
