public class Scriptures
{
    public List<Scriptures> all_scriptures = new List<Scriptures>();
    public List<Words> _words;
    private string _verseText;
    private Reference _reference;


    public Scriptures(string verseText, Reference reference)
    {
        _verseText = verseText;
        _reference = reference;
    }    
    public List<string> BreakDownScripture()
    {
        char parse_at = ' ';
        List<string> each_word = _verseText.Split(parse_at).ToList();
        return each_word;
    }
    public string DisplayScripture()
    {
        string display_text = "";
        foreach (Words word in _words)
        {
            if (word.GetHidden() == true)
            {
                int length = word.GetLength();
                for (int i = length; i >= 1; i--)
                {
                    display_text += "_";
                }
                display_text += " ";
            }
            else
            {
            display_text += word.GetText();
            }
        }
        return _reference.GetReference() + " " + display_text;
    }

    public void CreateScriptures()
    {
        Reference Nephi1_37 = new Reference("1 Nephi", 3, 7);
        Reference Nephi2_25 = new Reference("2 Nephi", 2, 25);
        Reference Nephi2_28_29 = new Reference("2 Nephi", 9, 28, 29);
        Reference Timothy2_16_17 = new Reference("2 Timothy", 3, 16, 17);
        Reference Moroni1_45 = new Reference("1 Nephi", 7, 45);

        Dictionary<Reference, string> scriptures = new()
        {
            {Nephi1_37, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."},
            {Nephi2_25,"Adam fell that men might be; and men are, that they might have joy."},
            {Nephi2_28_29, "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. 29- But to be learned is good if they hearken unto the counsels of God."},
            {Timothy2_16_17, "All scripture is given by inspiration of God, and is profitable for doctrine, for reproof, for correction, for instruction in righteousness: 17 That the man of God may be perfect, throughly furnished unto all good works."},
            {Moroni1_45, "And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things."}
        };

        foreach (KeyValuePair<Reference, string> pair in scriptures)
        {
            Scriptures new_scripture = new(pair.Value, pair.Key);
            //new_scripture._reference = pair.Key;
            //new_scripture._verseText = pair.Value;
            all_scriptures.Add(new_scripture);
        }
    }
    public void CreateWords(List<string> string_words)
    {
        List<Words> all_words = new();
        foreach (string word in string_words)
        {
            string text = word;
            int length = word.Count();
            Words new_word = new(text, length, false);
            all_words.Add(new_word);
        }
        _words = all_words;
    }
    public void HideWords()
    {
        List<Words> hidden_words = Words.HideWord(_words);
        _words = hidden_words;
    }
}