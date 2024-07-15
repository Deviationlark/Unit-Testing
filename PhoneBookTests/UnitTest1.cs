using PhoneBook;
namespace PhoneBookTests;

[TestClass]
public class PhoneBookTest
{
    [TestMethod]
    [DataRow("+15554875551")]
    public void ValidateNumber_IsValidNumber_ReturnTrue(string phoneNumber)
    {
        Assert.IsTrue(PhoneBookValidation.ValidateNumber(phoneNumber));
    }
}