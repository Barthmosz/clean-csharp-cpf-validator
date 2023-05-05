using System.Text.RegularExpressions;

namespace Clean.CpfValidator
{
    public static class CpfValidator
    {
        /// <summary>
        /// Validates an cpf.
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static bool Validate(string cpf)
        {
            string cpfRegex = "^\\d{3}\\.\\d{3}\\.\\d{3}-\\d{2}$";
            return Regex.IsMatch(cpf, cpfRegex);
        }
    }
}
