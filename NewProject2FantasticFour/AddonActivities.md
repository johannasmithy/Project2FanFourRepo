namespace ProjectOne;
class AddOnActivities
{
    public string ActivityName { get; set; }
    public int ActivityPrice { get; set; }
    public string ActivityLocation { get; set; }


    public AddOnActivities()
    {
        ActivityName = "";
        ActivityLocation = "";

    }

    public AddOnActivities(string activityName, int activityPrice, string activityLocation)
    {
        ActivityName = activityName;
        ActivityPrice = activityPrice;
        ActivityLocation = activityLocation;

    }
    
}

/*
Swimming
Snorkeling
Water Sports
Hiking
Riding Rollercoasters
Seeing Shows
Enjoying Water Parks
Whale Watching
Observing Glaciers
Nature Hike
Cultural Excursions
Exploring Ancient Ruins
Visiting Iconic Landmarks
Immersing in Art and Culture
Zip-Lining through forest canopies
Sandboarding Dunes
White-water Rafting
Attend Traditional Festivals
Learn Ancient Arts and Crafts
Visit Historic Temples
Explore Local Markets
Safari Drives 

    public string HikeWithGuide { get; set; }
    public string SeeingShows { get; set; }
    public string WaterPark { get; set; }
    public string WhaleWatchingVenture { get; set; }
    public string CulturalExcursion { get; set; }
    public string TourLandmarks { get; set; }
    public string ZipLine { get; set; }
    public string Sandboarding { get; set; }
    public string WhiteWaterRafting { get; set; }
    public string TraditionalCrafting { get; set; }
    public string TraditionalFestival { get; set; }
    public string SafariDrive { get; set; }
    public string BoatRide { get; set; }
*/