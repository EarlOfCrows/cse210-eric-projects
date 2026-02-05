public class Scriptures
{
    List<Scriptures> all_scriptures = new List<Scriptures>();
    private string _reference;
    private string _verse_text;

    public void CreateScriptures(){
        Dictionary<string, string> scriptures = new Dictionary<string, string>
        {
            {"2 Nephi 2:25", "Adam fell that men might be; and men are, that they might have joy"},
            {"2 Nephi 25:23", "It is by grace that we are saved, after all we can do"},
            {"Mosiah 2:17", "when ye are in the service of your fellow beings ye are only in the service of your God"},
            {"Ether 12:27","My grace is sufficient for all men that humble themselves before me"},
            {"Moroni 10:32","Yea, come unto Christ, and be perfected in him, and deny yourselves of all ungodliness; and if ye shall deny yourselves of all ungodliness, and love God with all your might, mind and strength, then is his grace sufficient for you, that by his grace ye may be perfect in Christ; and if by the grace of God ye are perfect in Christ, ye can in nowise deny the power of God."}
        };

        foreach (KeyValuePair<string, string> scripture_data in scriptures)
        {
            Scriptures new_scripture = new Scriptures();
            new_scripture._reference = scripture_data.Key;
            new_scripture._verse_text = scripture_data.Value;
            all_scriptures.Add(new_scripture);
            //Console.WriteLine($"ref: {new_scripture._reference}\ntext: {new_scripture._verse_text}");
            Console.WriteLine(all_scriptures);
        } 
    }
    
}