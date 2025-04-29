
using System;

namespace NameofDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var usuario = new Usuario { Email = null, Nome = "João" };

            if (string.IsNullOrEmpty(usuario.Email))
                throw new ArgumentException("Campo obrigatório", nameof(usuario.Email));
        }
    }

    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
