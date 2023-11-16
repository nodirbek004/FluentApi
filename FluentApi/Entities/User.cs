namespace FluentApi.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int AddressId { get; set; }
    public Address Address { get; set; }
    public IEnumerable<Category> Category { get; set; }
}
