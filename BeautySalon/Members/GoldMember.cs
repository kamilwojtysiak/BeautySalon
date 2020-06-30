using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon
{
    public class GoldMember : Member
    {
        public GoldMember(string name, double phoneNumber, double price, string dateOfVisit) : base(name, phoneNumber, price, dateOfVisit)
        {

        }

        public override void CalculatePrice()
        {
            _discount = 0.4 * _priceForService;
            _priceWithDiscount = _priceForService - _discount;
        }

        public override string ToString()
        {
            return "\n***GOLD STATUS*** \nCustomer name: " + _customerName + "\nPhone number: " + _customerPhoneNumber + "\nDate of visit: " + _dateOfVisit + "\nRegular price: " +_priceForService + "PLN(discount = " + _discount + "PLN)." + "\nPrice with discount: " + _priceWithDiscount + "PLN";
        }
    }
}
