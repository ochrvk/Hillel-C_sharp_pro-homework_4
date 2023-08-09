namespace Task_4
{
    public class CreditCard
    {
        private string _cardNumber;
        private int _cvcCode;
        private decimal _balance;

        public string CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }

        public int CVCCode
        {
            get { return _cvcCode; }
            set
            {
                if (value >= 100 && value <= 999)
                    _cvcCode = value;
                else
                    throw new ArgumentOutOfRangeException("The CVC code must be a three-digit number");
            }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public CreditCard(string cardNumber, int cvcCode, decimal balance)
        {
            this._cardNumber = cardNumber;
            this._cvcCode = cvcCode;
            this._balance = balance;
        }


        public static CreditCard operator +(CreditCard card, decimal amount)
        {
            card._balance += amount;
            return card;
        }


        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            if (card._balance < amount)
                throw new InvalidOperationException("Not enough money on the card");

            card._balance -= amount;
            return card;
        }


        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            if (ReferenceEquals(card1, null) || ReferenceEquals(card2, null))
                return false;
            return card1._cvcCode == card2._cvcCode;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return !(card1 == card2);
        }


        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            if (ReferenceEquals(card1, null) || ReferenceEquals(card2, null))
                throw new ArgumentException("Objects must not be null");

            return card1._balance < card2._balance;
        }


        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            if (ReferenceEquals(card1, null) || ReferenceEquals(card2, null))
                throw new ArgumentException("Objects must not be null");

            return card1._balance > card2._balance;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            CreditCard other = (CreditCard)obj;
            return _cardNumber == other.CardNumber && _cvcCode
                 == other.CVCCode && _balance == other.Balance;
        }
    }
}
