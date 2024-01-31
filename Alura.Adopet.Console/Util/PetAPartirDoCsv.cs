using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util
{
    public static class PetAPartirDoCsv
    {
        public static Pet ConverteDoTexto(this string linha)
        {
            if (string.IsNullOrEmpty(linha))
                throw new ArgumentNullException();

            string[]? propriedades = linha.Split(';');

            if (!Guid.TryParse(propriedades[0], out Guid guid))
                throw new FormatException("Guid invalido");

            if (propriedades.Length < 3)
                throw new Exception();

            return new Pet(Guid.Parse(propriedades[0]),
            propriedades[1],
            int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro
            );
        }
    }
}
