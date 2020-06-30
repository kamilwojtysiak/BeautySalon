using System;
using System.Data;

namespace BeautySalon
{
    public class Member
    {
        protected string _customerName;
        protected double _customerPhoneNumber;
        protected double _priceForService;
        protected double _discount;
        protected double _priceWithDiscount;
        protected string _dateOfVisit;

        public Member(string customerName, double customerPhoneNumber, double priceForService, string dateOfVisit)
        {
            _customerName = customerName;
            _customerPhoneNumber = customerPhoneNumber;
            _priceForService = priceForService;
            _dateOfVisit = dateOfVisit;
        }

        public virtual void CalculatePrice()
        {
            _discount = 0.1 * _priceForService;
            _priceWithDiscount = _priceForService - _discount;
        }

        public override string ToString()
        {
            return "***REGULAR STATUS*** \nCustomer name: " + _customerName + "\nPhone number: " + _customerPhoneNumber + "\nDate of visit: " + _dateOfVisit + "\nRegular price: " + _priceForService + "PLN(discount = " + _discount + "PLN)." + "\nPrice with discount: " + _priceWithDiscount + "PLN";
        }
    }
}
