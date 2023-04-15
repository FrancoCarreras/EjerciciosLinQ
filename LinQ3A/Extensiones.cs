namespace EjemplosWin
{
    public static class Extensiones
    {
        public static string Left(this string valor, int caracteres)
        {
            return valor.Substring(0, caracteres);
        }
        public static string Right(this string valor, int caracteres)
        {
            return valor.Substring(caracteres);
        }
    }
}
