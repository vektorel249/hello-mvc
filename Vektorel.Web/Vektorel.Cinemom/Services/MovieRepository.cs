using Vektorel.Cinemom.Models.Entities;

namespace Vektorel.Cinemom.Services
{
    public class MovieRepository
    {
        public MovieRepository()
        {
            Console.WriteLine("Uygulama hazır ve ben de sonun kadar buradayım :D");
        }
        public List<Movie> GetMovies()
        {
            // veritabanı sorgusu
            return new List<Movie>
            {
                new Movie { Id = 1, Title = "Inception", PublishedYear = 2010, Description = "Christopher Nolan tarafından yönetilen, zihin bükücü bir gerilim filmi.", Rating = 9 },
                new Movie { Id = 2, Title = "The Dark Knight", PublishedYear = 2008, Description = "Batman, en büyük zorlukla Joker ile yüzleşiyor.", Rating = 9 },
                new Movie { Id = 3, Title = "The Matrix", PublishedYear = 1999, Description = "Bir bilgisayar korsanı, gerçekliğin gerçek doğasını keşfeder.", Rating = 10 },
                new Movie { Id = 4, Title = "The Godfather", PublishedYear = 1972, Description = "Bir suç ailesinin gücünü anlatan etkileyici bir hikaye.", Rating = 10 },
                new Movie { Id = 5, Title = "Pulp Fiction", PublishedYear = 1994, Description = "Quentin Tarantino'nun yazıp yönettiği bir dizi iç içe geçmiş hikaye.", Rating = 5 },
                new Movie { Id = 6, Title = "The Shawshank Redemption", PublishedYear = 1994, Description = "Yanlış bir suçtan hüküm giyen bir adam, hapiste bir dostluk kurar.", Rating = 10 },
                new Movie { Id = 7, Title = "Forrest Gump", PublishedYear = 1994, Description = "Düşük IQ'lu bir adam, tarihi anları farkında olmadan etkiler.", Rating = 7 },
                new Movie { Id = 8, Title = "The Lion King", PublishedYear = 1994, Description = "Genç bir aslan yavrusunun, Pride Lands'in kralı olma yolundaki macerası.", Rating = 8 },
                new Movie { Id = 9, Title = "Titanic", PublishedYear = 1997, Description = "RMS Titanic felaketiyle arka planda trajik bir aşk hikayesi.", Rating = 8 },
                new Movie { Id = 10, Title = "Jurassic Park", PublishedYear = 1993, Description = "Dinozorlar bir tema parkında yeniden hayata döndürülür, kaosa yol açar.", Rating = 4 },
                new Movie { Id = 11, Title = "Avengers: Endgame", PublishedYear = 2019, Description = "Avengers, Thanos tarafından yok edilen evreni geri getirmek için savaşır.", Rating = 9 },
                new Movie { Id = 12, Title = "The Social Network", PublishedYear = 2010, Description = "Facebook'un yaratılış hikayesi ve etrafındaki tartışmalar.", Rating = 8 },
                new Movie { Id = 13, Title = "Gladiator", PublishedYear = 2000, Description = "İhanete uğramış bir Roma generalinin, yozlaşmış imparatora karşı intikam alışı.", Rating = 6 },
                new Movie { Id = 14, Title = "The Terminator", PublishedYear = 1984, Description = "Bir cyborg suikastçısı, gelecekten bir kadını öldürmek için gönderilir.", Rating = 8 },
                new Movie { Id = 15, Title = "Star Wars: Episode IV - A New Hope", PublishedYear = 1977, Description = "Genç bir çiftlik çocuğu, kötü bir imparatorluğa karşı bir isyanda yer almak için yolculuğa çıkar.", Rating = 10 }
            };
        }
    }
}
