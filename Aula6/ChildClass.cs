namespace Aula6
{
    internal class ChildClass : BaseClass
    {
        private string MiddleName { get; set; }

        /// <summary>
        /// Por padrão todos os fields de uma classe são privadas, deste modo se não adcionarmos a palavra "public" na frente deste campo ele ficara acessivel apenas dentro desta classe
        /// </summary>
        string SecondName = "Just an example";

        /// <summary>
        /// Classes podem ter membros estáticos, porem esses membros não podem ser acessados pela instância da classe e sim pelo nome da classe
        /// <code>
        /// Console.WriteLine(ChildClass.BaseType);
        /// </code>
        /// </summary>
        public const string BaseType = nameof(BaseClass);

        /// <summary>
        /// Usamos :base() para chamar o construtor da classe "Pai" e passarmos os parâmetros do construtor.
        ///   Repare que o parâmetro "middleName" é um membro apenas desta classe, outras classes derivadas de BaseClass não teram acesso a ele
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="middleName"></param>
        public ChildClass(string name, string lastName, string middleName) :base(name, lastName)
        {
            MiddleName = middleName;
        }

        /// <summary>
        /// Para sobrepor os métodos abstratos da classe base precisamos usar a palavra "override"
        /// </summary>
        /// <returns></returns>
        public override string GetFullName()
        {
            return $"{Name} {MiddleName} {LastName}";
        }

    }
}
