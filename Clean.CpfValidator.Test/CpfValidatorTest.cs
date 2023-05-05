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

        [Test, Description("ensure CpfValidator returns false if an empty cpf is provided")]
        public void CpfValidator_EmptyCpf_ReturnsFalse()
        {
            Assert.That(CpfValidator.Validate(""), Is.EqualTo(false));
        }

        [Test, Description("ensure CpfValidator returns true if a valid cpf is provided")]
        public void CpfValidator_ValidCpf_ReturnsFalse()
        {
            Assert.That(CpfValidator.Validate("123.456.789-12"), Is.EqualTo(true));
        }
    }
}
