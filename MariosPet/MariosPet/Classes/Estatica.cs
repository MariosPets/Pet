namespace MariosPet.Classes
{
    public enum TipoAcao { 
        inserir,
        alterar
    }

    public enum BuscaTipo{
        geral,
        cliente,
        funcionario,
        animal
    }

    static class Estatica
    {
        public static int id = 0;
        public static Cliente cliente = new Cliente();
        public static Funcionario funcionario = new Funcionario();
        public static Animal animal = new Animal();
        public static bool novo;
        public static BuscaTipo buscaTipo;
        public static TipoAcao tipoAcao;
    }
}
