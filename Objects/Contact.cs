using System.Collections.Generic;

namespace Address.Objects
{
  public class Contact
  {
    private string _firstName;
    private string _lastName;
    private int _phoneNumber;
    private string _streetAddress;
    private string _city;
    private string _state;
    private int _zipCode;
    private static List<Contact> _allContacts = new List<Contact> {};

    public Contact(string firstName, string lastName, int phoneNumber, string streetAddress, string city, string state, int zipCode)
    {
      _firstName = firstName;
      _lastName = lastName;
      _phoneNumber = phoneNumber;
      _streetAddress = streetAddress;
      _city = city;
      _state = state;
      _zipCode = zipCode;
    }
    public string GetFirstName()
    {
      return _firstName;
    }
    public void SetFirstName(string newFirstName)
    {
      _firstName = newFirstName;
    }
    public string GetLastName()
    {
      return _lastName;
    }
    public void SetLastName(string newLastName)
    {
      _lastName = newLastName;
    }
    public int GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(int newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
    public string GetStreetAddress()
    {
      return _streetAddress;
    }
    public void SetStreetAddress(string newStreetAddress)
    {
      _streetAddress = newStreetAddress;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string newCity)
    {
      _city = newCity;
    }
    public string GetState()
    {
      return _state;
    }
    public void SetState(string newState)
    {
      _state = newState;
    }

    private int GetZipCode()
    {
      return _zipCode;
    }
    private void SetZipCode(int newZipCode)
    {
      _zipCode = newZipCode;
    }
    public static List<Contact> GetAll()
    {
      return _allContacts;
    }
    public void Save()
    {
      _allContacts.Add(this);
    }
    public static void DeleteAll()
    {
      _allContacts.Clear();
    }
  }
}
