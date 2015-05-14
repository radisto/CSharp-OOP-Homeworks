using System;
using System.Collections.Generic;

class Customer : ICloneable, IComparable<Customer>
{
    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public string Id { get; set; }

    public string Address { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public List<Payment> Payments { get; set; }

    public CustomerType CustomerType { get; set; }

    public Customer(string firstName, string middleName, string lastName, string id, string address,
        string phone, string email, List<Payment> payments, CustomerType customerType)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.Id = id;
        this.Address = address;
        this.Phone = phone;
        this.Email = email;
        this.Payments = payments;
        this.CustomerType = customerType;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        Customer cust = obj as Customer;
        if ((object)cust == null)
        {
            return false;
        }
        return (this.FirstName == cust.FirstName &&
                this.MiddleName == cust.MiddleName &&
                this.LastName == cust.LastName &&
                this.Id == cust.Id &&
                this.Address == cust.Address &&
                this.Phone == cust.Phone &&
                this.Email == cust.Email);
    }

    public override int GetHashCode()
    {
        return this.GetHashCode();
    }

    public override string ToString()
    {
        return string.Format("Name: {0} {1} {2} ID: {3} Address: {4} Phone: {5} Email: {6}",
            this.FirstName, this.MiddleName, this.LastName, this.Id, this.Address, this.Phone, this.Email);
    }

    public static bool operator ==(Customer a, Customer b)
    {
        if (ReferenceEquals(a, b))
        {
            return true;
        }

        if (((object)a == null) || ((object)b == null))
        {
            return false;
        }
        return (a.FirstName == b.FirstName &&
                a.MiddleName == b.MiddleName &&
                a.LastName == b.LastName &&
                a.Id == b.Id &&
                a.Address == b.Address &&
                a.Phone == b.Phone &&
                a.Email == b.Email);
    }

    public static bool operator !=(Customer a, Customer b)
    {
        return !(a == b);
    }

    public object Clone()
    {
        return new Customer(this.FirstName, this.MiddleName, this.LastName, this.Id, this.Address, this.Phone, this.Email, this.Payments, this.CustomerType);
    }

    public int CompareTo(Customer other)
    {
        string aName = this.FirstName + ' ' + this.MiddleName + ' ' + this.LastName;
        string bName = other.FirstName + ' ' + other.MiddleName + ' ' + other.LastName;
        if (aName == bName)
        {
            return this.Id.CompareTo(other.Id);
        }
        return aName.CompareTo(bName);
    }
}