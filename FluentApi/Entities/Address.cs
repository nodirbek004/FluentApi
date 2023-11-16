namespace FluentApi.Entities;

public class Address
{
    public int Id { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }

    public IEnumerable<User> Users { get; set; }

}
