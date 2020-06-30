using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon
{
    public class BrownMember : Member
    {
        public BrownMember(string name, double phoneNumber, double price, string dateOfVisit) : base(name, phoneNumber, price, dateOfVisit)
        {
          
        }

        public override void CalculatePrice()
        {
            _discount = 0.2 * _priceForService;
            _priceWithDiscount = _priceForService - _discount;
        }

        public override string ToString()
        {
            return "\n***BROWN STATUS*** \nCustomer name: " + _customerName + "\nPhone number: " + _customerPhoneNumber + "\nDate of visit: " + _dateOfVisit + "\nRegular price: " + _priceForService + "PLN(discount = " + _discount + "PLN)." + "\nPrice with discount: " + _priceWithDiscount + "PLN";
        }
    }
}
