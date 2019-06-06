namespace TaskManagerApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext()
            : base("name=TaskManagerContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
}