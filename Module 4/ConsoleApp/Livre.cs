namespace ConsoleApp
{
    public class Livre
    {
        public string? Titre { get; set; }
        public string? Auteur { get; set; }
        public int? NombreDePages { get; set; }
        public DateTime? DatePublication { get; set; }
        public bool? DispoMagasin { get; set; }
        public Genre? Genre { get; set; }

        public override string ToString()
        {
            return $"{this.Titre} de {this.Auteur}, {this.Genre} de {this.NombreDePages} pages, publié le {this.DatePublication}, {(this.DispoMagasin.Value ? "disponible" : "non disponible")} en magasin";
        }

        public Livre()
        {

        }

        public Livre(Livre copy)
        {
            this.Titre = copy.Titre;
            this.Auteur = copy.Auteur;
            this.NombreDePages = copy.NombreDePages;
            this.DatePublication = copy.DatePublication;
            this.DispoMagasin = copy.DispoMagasin;
            this.Genre = copy.Genre;
        }

        public int GetTempsEstimeSeconds()
        {
            return this.NombreDePages.Value * 30;
        }
        //ou
        public int TempsEstimeSeconds => this.NombreDePages.Value * 30;
    }
}
