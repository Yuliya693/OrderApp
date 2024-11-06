using System;
using System.ComponentModel.DataAnnotations;
namespace OrderApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; } = string.Empty;
        [Required(ErrorMessage = "Город отправителя обязателен")]
        [RegularExpression(@"^[A-Za-zА-Яа-яЁё\s-]+$", ErrorMessage = "Город может содержать только буквы и пробелы")]
        public string SenderCity { get; set; } = string.Empty;
        [Required(ErrorMessage = "Адрес отправителя обязателен")]
        [RegularExpression(@"^[\p{L}\s]+ \d+$", ErrorMessage = "Адрес должен включать название улицы и номер дома (например, 'Ленина 5')")]
        public string SenderAddress { get; set; } = string.Empty;
        [Required(ErrorMessage = "Город получателя обязателен")]
        [RegularExpression(@"^[A-Za-zА-Яа-яЁё\s-]+$", ErrorMessage = "Город может содержать только буквы и пробелы")]
        public string RecipientCity { get; set; } = string.Empty;
        [Required(ErrorMessage = "Адрес получателя обязателен")]
        [RegularExpression(@"^[\p{L}\s]+ \d+$", ErrorMessage = "Адрес должен включать название улицы и номер дома (например, 'Ленина 5')")]
        public string RecipientAddress { get; set; } = string.Empty;
        [Required(ErrorMessage = "Вес груза обязателен")]
        [RegularExpression(@"^\d+\s?(кг|г|гр)$", ErrorMessage = "Вес должен быть в формате '12 кг' или '500 г'")]
        public string? CargoWeight { get; set; }
        [Required(ErrorMessage = "Дата забора груза обязательна")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public  DateTime PickupDate { get; set; }
    }
}
