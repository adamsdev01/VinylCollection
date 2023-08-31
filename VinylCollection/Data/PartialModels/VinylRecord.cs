namespace VinylCollection.Data.Models
{
    public partial class VinylRecord
    {
        public string ArtistFullName
        {
            get { return ArtistFirstName + " " + ArtistLastName; }

        }
    }
}
