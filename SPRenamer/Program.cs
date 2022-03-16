namespace SPRenamer;

public class Program
{
    public static void Main(string[] args)
    {
        var sourceDir = args?.Length > 0 ? args[0] : string.Empty;
        var targetDir = args?.Length > 1 ? args[1] : string.Empty;

        if (sourceDir.Trim().ToLowerInvariant().Contains("help"))
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("  SPRenamer.exe SOURCEDIR TARGETDIR");
            return;
        }

        if (string.IsNullOrWhiteSpace(sourceDir))
        {
            Console.Write("Source directory? ");
            sourceDir = Console.ReadLine();
        }

        if (string.IsNullOrWhiteSpace(targetDir))
        {
            Console.Write("Target directory? ");
            targetDir = Console.ReadLine();
        }

        var sourceDirInfo = new DirectoryInfo(sourceDir);
        if (!sourceDirInfo.Exists)
        {
            Console.WriteLine($"The source directory {sourceDir} does not exist.");
            return;
        }

        var targetDirInfo = new DirectoryInfo(targetDir);
        if (!targetDirInfo.Exists) 
        {
            Console.WriteLine($"The target directory {targetDir} does not exist.");
            return;
        }

        var renamer = new AudioRenamer();
        renamer.Rename(sourceDirInfo, targetDirInfo);
    }
}