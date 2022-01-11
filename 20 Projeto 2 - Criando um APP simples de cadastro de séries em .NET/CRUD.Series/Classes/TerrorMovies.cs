using CRUD.TerrorMovies.Classes;

namespace CRUD.TerrorMovies
{
    public class TerrorMovie : BaseEntity
    {
            //Atributos
            private Genre Genre { get; set; }
            private Subgenre Subgenre { get; set; }
            private string Title { get; set; }
            private string Description { get; set; }
            private int Year { get; set; }
            private bool Deleted { get; set; }
            
            //Métodos
            public TerrorMovie(int id, Genre genre, Subgenre subgenre, string title, string description, int year)
            {
                this.Id = id;
                this.Genre = genre;
                this.Subgenre = subgenre;
                this.Title = title;
                this.Description = description;
                this.Year = year;
                this.Deleted = false;
            }

        public override string ToString()
        {
            string ret = "";
            ret += "Genre: " + this.Genre + Environment.NewLine;
            ret += "Subgenre: " + this.Subgenre + Environment.NewLine;
            ret += "Title: " + this.Title + Environment.NewLine;
            ret += "Description: " + this.Description + Environment.NewLine;
            ret += "Year: " + this.Year + Environment.NewLine;
            ret += "Deleted: " + this.Deleted + Environment.NewLine;
            return ret;
        }

        public string returnTitle()
        {
            return this.Title;
        }

        public int returnId()
        {
            return this.Id;
        }

        public bool ReturnDeleted()
        {
            return this.Deleted;
        }

        public void Delete() {
            this.Deleted = true;
        }
    }
}