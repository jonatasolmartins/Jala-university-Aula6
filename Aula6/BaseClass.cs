namespace Aula6
{
    /// <summary>
    /// A palavra abstract aqui significa que a classe BaseClass não pode ser instanciada.
    /// </summary>
    internal abstract class BaseClass
    {
        /// <summary>
        /// o modificador de acesso "protected" torna essas propriedades acessíveis apenas por esta classe e as classes que herdar dela
        /// </summary>
        protected string Name { get; set; }
        protected string LastName { get; set; }

        protected BaseClass(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        
        /// <summary>
        /// Também podemos declarar que um método é abstratos. 
        /// Isso seguinifica que esse método precisa ser implemntado pela classe que herdar desta classe
        /// </summary>
        /// <returns>Full name</returns>
        public abstract string GetFullName();
    }
}
