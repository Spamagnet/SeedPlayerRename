namespace SPRenamer;

public static class AudioHelper
{
    // B01___01_Matthew_____ENGNRSN1DA.mp3
    // A19__113_Psalms______ENGESVO1DA.mp3
    // 0123456789012345678901234567890
    // 0.........1.........2.........3
    public static AudioMetadata ParseFileName(string fileName)
    {
        var bookPrefix = fileName.Substring(0,1);
        var bookIndex = fileName.Substring(1,2);
        var chapterIndex = fileName.Substring(5,4);
        var bookName = fileName.Substring(9,21-9);
        var language = fileName.Substring(21);

        var meta = new AudioMetadata
        {
            BookPrefix = bookPrefix,
            BookIndex = ConvertInteger(bookIndex),
            ChapterIndex = ConvertInteger(chapterIndex),
            BookName = NormalizeBookName(bookName),
            Language = language
        };
        return meta;
    }

    // 001_Matthew
    public static string GenerateTargetFolder(AudioMetadata meta)
    {
        var name = $"{meta.BookIndex:000}_{meta.BookName}";
        return name;
    }

    // 001_Matthew_____SOMTVIN2DA.mp3
    // 01234567890123456789012345
    // 0.........1.........2.....
    public static string GenerateTargetFileName(AudioMetadata meta)
    {
        const int widthBook = 16 - 4;
        var name = $"{meta.ChapterIndex:000}_{meta.BookName.PadRight(widthBook,'_')}{meta.Language}.mp3";
        return name;
    }

    private static int ConvertInteger(string text)
    {
        return int.Parse(text.Replace("_", string.Empty));
    }

    public static string NormalizeBookName(string text)
    {
        return text.Replace("_", " ").Trim();
    }
}