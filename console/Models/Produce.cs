namespace console
{
    public class IProduce
    {
        public int Value {get; set;}
        public bool IsKing {get; set;}
        public bool IsQueen {get; set;}
        public int Number {get; set;}
        public int RoyalNumber {get; set;}
    }


    public class Apples : IProduce
    {
        public int Value = 2;
        public bool IsKing = false;
        public bool IsQueen = false;
        public int Number = 0;
        public int RoyalNumber = 0;
    }
}
 