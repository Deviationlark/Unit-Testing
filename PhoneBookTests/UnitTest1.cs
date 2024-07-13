using PhoneBook;
namespace PhoneBook.Tests;

[TestClass]
public class PhoneBookTest
{
    private readonly PhoneBookValidation _validation;
    public PhoneBookTest(PhoneBookValidation validation)
    {
        _validation = validation;
    }
    [TestMethod]
    public void ValidateNumber_IsValidNumber_ReturnTrue(string phoneNumber)
    {
        Validation
    }
}