using System.Collections.Generic;
using System.Linq;
using NooBIT.DataTables.Queries;

namespace NooBIT.DataTables.Tests.Models
{
    public class TestEntityDataSource : IDataSource<TestEntity>
    {
        public static readonly List<TestEntity> Entities = new List<TestEntity>
        {
            new TestEntity {Id = 7, Name = "Alfred"},
            new TestEntity {Id = 3, Name = "Bertram"},
            new TestEntity {Id = 8, Name = "Christian"},
            new TestEntity {Id = 2, Name = "Dominik"},
            new TestEntity {Id = 6, Name = "Elfriede"},
            new TestEntity {Id = 1, Name = "Florian"},
            new TestEntity {Id = 5, Name = "Gerhard"},
            new TestEntity {Id = 4, Name = "Hildegard"}
        };

        public IQueryable<TestEntity> Get()
        {
            return Entities.AsQueryable();
        }
    }
}