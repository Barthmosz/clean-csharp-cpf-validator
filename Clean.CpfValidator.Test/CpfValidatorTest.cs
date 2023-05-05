using NUnit.Framework;

namespace Clean.CpfValidator.Test
{
    [TestFixture]
    public class CpfValidatorTest
    {
        [Test, Description("ensure CpfValidator returns false if an invalid cpf is provided")]
        public void CpfValidator_InvalidCpf_ReturnsFalse()
        {
            Assert.That(CpfValidator.Validate("123.456.678"), Is.EqualTo(false));
        }
    }
}
