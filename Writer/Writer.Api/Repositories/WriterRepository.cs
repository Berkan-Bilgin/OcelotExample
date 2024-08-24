using Core.DataAccess;
using Writer.Api.Data;
using Writer.Api.Models;
using Writer.Api.Repositories.Interfaces;

namespace Writer.Api.Repositories
{
    public class WriterRepository : EfRepositoryBase<Models.Writer, WriterDbContext>, IWriterRepository
    {
        public WriterRepository(WriterDbContext context) : base(context)
        {
        }
    }

    //public class WriterRepository : List<Models.Writer>, IWriterRepository
    //{

    //    //Databaseden gelicek veriler.
    //    private static List<Models.Writer> writers = populateWriters();
    //    private static List<Models.Writer> populateWriters()
    //    {
    //        return new List<Models.Writer>()
    //    {
    //        new Models.Writer()
    //        {
    //            Id=1,
    //            Name = "ibrahim gökyar"
    //        },
    //         new Models.Writer()
    //        {
    //            Id=2,
    //            Name = "hakan yılmaz"
    //        },
    //          new Models.Writer()
    //        {
    //            Id=3,
    //            Name = "metin yıldız"
    //        }
    //    };
    //    }

    //    public List<Models.Writer> GetAll()
    //    {
    //        return writers;
    //    }

    //    public Models.Writer? GetById(int id)
    //    {
    //        return writers.FirstOrDefault(x => x.Id == id);
    //    }

    //    public Models.Writer Insert(Models.Writer writer)
    //    {
    //        var maxId = writers.Max(x => x.Id);
    //        writer.Id = ++maxId;
    //        writers.Add(writer);
    //        return writer;
    //    }
    //}
}
