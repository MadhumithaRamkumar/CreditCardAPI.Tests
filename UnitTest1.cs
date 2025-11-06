using CreditCardAPI.Services;
namespace CreditCardAPI.Tests
{
    public class UnitTest1
    {
        private readonly ILuhnService _service = new LuhnService();
        [Theory]
        
        [InlineData("5555555555554444", true)]
        [InlineData("4242 4242 4242 4242", true)]
        [InlineData("4242424242424242", true)]
        [InlineData("4111111111111111", true)]
        [InlineData("4242424242424241", false)]
        [InlineData("", false)]
        [InlineData("****", false)]
        [InlineData("abcd-1234", false)]

        public void Test1(string number, bool expected)
        {
            Assert.Equal(expected, _service.IsValid(number).IsValid);
        }
    }
}