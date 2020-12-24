namespace BonusExercise
{
    public class Address
    {
        // —упер, как всегда хорошо! ≈динственный момент, на который € бы обратил внимание,
        // это касательно свойств. ≈сли внутри свойства не реализуетс€ дополнительгна€ логика
        // есть смысл использовать автосвойства. Ёто и быстрее :) 
        
        private int index;
        private string country;
        private string city;
        private string street;
        private string house;
        private int apartment;

        public int Index
        {
            get => index;
            set => index = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Street
        {
            get => street;
            set => street = value;
        }

        public string House
        {
            get => house;
            set => house = value;
        }

        public int Apartment
        {
            get => apartment;
            set => apartment = value;
        }
    }
}