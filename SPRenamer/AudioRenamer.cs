namespace SPRenamer;

public class AudioRenamer
{
    public void Rename(DirectoryInfo source, DirectoryInfo target)
    {
        Console.WriteLine(source.FullName);
        Console.WriteLine(target.FullName);

        var files = source.GetFiles("*.mp3");
        foreach (var file in files)
        {
            var baseName = Path.GetFileNameWithoutExtension(file.FullName);
            var meta = AudioHelper.ParseFileName(baseName);

            var targetFolder = AudioHelper.GenerateTargetFolder(meta);
            var targetFileName = AudioHelper.GenerateTargetFileName(meta);

            var targetDir = Path.Combine(target.FullName, targetFolder);
            if (!Directory.Exists(targetDir))
                Directory.CreateDirectory(targetDir);

            var targetFilePath = Path.Combine(targetDir, targetFileName);
            File.Copy(file.FullName, targetFilePath);
        }
    }
}