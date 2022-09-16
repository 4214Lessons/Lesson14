using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson14;


// static class ExtMethods
// {
//     // public static IEnumerator<int> GetEnumerator(this int  n)
//     // {
//     //     for (int i = 0; i < n; i++)
//     //         yield return i;
//     // }
// 
// 
//     public static IEnumerator<int> GetEnumerator(this int n)
//         => Enumerable.Range(0, n).GetEnumerator();
// }
// 
// class Program
// {
//     static void Main()
//     {
//         int x = 10;
//         foreach (int i in x)
//             Console.WriteLine(i);
// 
//     }
// }







// --- Stream ---

// Stream
// FileStream
// MemoryStream
// NetworkStream
// UnmanagedMemoryStream
// PipeStream
// CryptoStream
// BufferedStream



// --- Helper classes or Adapters ---

// TextWriter, TextReader
// StreamWriter, StreamReader
// BinaryWriter, BinaryReader
// XmlWriter, XmlReader





// --- Compression ---

// GZipStream
// DeflateStream




// --- File, Directory, Path ---

// File
// FileInfo
// Directory
// DirectoryInfo
// Path


#nullable disable


class Program
{
    static void Main()
    {
        #region Write with FileStream
        // using (FileStream fs = new FileStream("test.txt", FileMode.Create, FileAccess.Write, FileShare.None))
        // {
        //     Console.Write("Enter some text: ");
        //     string str = Console.ReadLine();
        //     byte[] buffer = Encoding.Default.GetBytes(str);
        //     fs.Write(buffer, 0, buffer.Length);
        //     
        //     // fs.Flush();
        //     // fs.Close();
        // }
        #endregion



        #region Read with FileStream
        // using (FileStream fs = new FileStream("test.txt", FileMode.Open))
        // {
        //     byte[] buffer = new byte[fs.Length];
        //     fs.Read(buffer, 0, buffer.Length);
        // 
        //     string str = Encoding.Default.GetString(buffer, 0, buffer.Length);
        //     Console.WriteLine(str);
        // }
        #endregion







        #region Write with StreamWriter (Adapter)

        // using FileStream fs = new FileStream("hakuna.txt", FileMode.OpenOrCreate);
        // using StreamWriter sw = new StreamWriter(fs);

        // sw.WriteLine("Hakuna Matata");




        // using StreamWriter sw = new StreamWriter("books.txt");
        // 
        // List<Book> books = new()
        // {
        //     new Book(1, "Joseph Albahari", "C# in a Nutshell", "Programming"),
        //     new Book(2, "Jeffrey Richter", "CLR VIA C#", "Programming"),
        //     new Book(3, "Antoine de Saint-Exupéry", "The Little Prince", "Kid")
        // };
        // 
        // books.ForEach(book => sw.WriteLine(book));

        #endregion



        #region Read with StreamReader (Adapter)

        // using StreamReader sr = new StreamReader("books.txt");
        // Console.WriteLine(sr.ReadToEnd());

        #endregion







        #region Write with BinaryWriter (Adapter)

        // using FileStream fs = new FileStream("binaryEx.bin", FileMode.Create);
        // using BinaryWriter bw = new BinaryWriter(fs);
        // 
        // bw.Write("Hello");
        // bw.Write(15);
        // bw.Write(false);
        // bw.Write(5.6f);

        #endregion



        #region Read with BinaryReader (Adapter)

        // using FileStream fs = new FileStream("binaryEx.bin", FileMode.Open);
        // using BinaryReader br = new BinaryReader(fs);
        // 
        // Console.WriteLine(br.ReadString());
        // Console.WriteLine(br.ReadInt32());
        // Console.WriteLine(br.ReadBoolean());
        // Console.WriteLine(br.ReadSingle());

        #endregion







        #region Directory, DirectoryInfo


        // Console.WriteLine(Directory.GetCurrentDirectory());


        // Directory.CreateDirectory("C:\\Users\\t.novruzov\\Desktop\\Folder1");
        // Directory.CreateDirectory("C:/Users/t.novruzov/Desktop/Folder2");
        // Directory.CreateDirectory(@"C:\Users\t.novruzov\Desktop\Folder3");
        // Directory.CreateDirectory(@$"C:\Users\{Environment.UserName}\Desktop\Folder4");
        // Directory.CreateDirectory(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Folder5");

        // Directory.Delete(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Folder5");




        // DirectoryInfo directoryInfo = new(Directory.GetCurrentDirectory());
        // DirectoryInfo directoryInfo = new(".");
        // DirectoryInfo directoryInfo = new(@$"C:\Users\{Environment.UserName}\Desktop");
        // 
        // // foreach (FileInfo file in directoryInfo.GetFiles())
        // //     Console.WriteLine(file.Name);
        // 
        // 
        // foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
        // {
        //     Console.WriteLine(directory.Root);
        //     Console.WriteLine(directory.Parent);
        //     Console.WriteLine(directory.FullName);
        // }





        // //DirectoryInfo directoryInfo = new(".");
        // DirectoryInfo directoryInfo = new("../../..");
        // // DirectoryInfo directoryInfo = new("./Images");
        // // DirectoryInfo directoryInfo = new("Images/");
        // Console.WriteLine(directoryInfo.FullName);


        #endregion



        #region File, FileInfo


        // File.WriteAllText("file.txt", "content");
        // var str = File.ReadAllText("file.txt");
        // Console.WriteLine(str);
        // 
        // 
        // Console.WriteLine(File.Exists("file.txt"));


        // FileInfo fileInfo = new("file.txt");
        // 
        // 
        // Console.WriteLine(fileInfo.Extension);
        // Console.WriteLine(fileInfo.Name);
        // Console.WriteLine(fileInfo.CreationTime);
        // Console.WriteLine(fileInfo.Length);
        // Console.WriteLine(fileInfo.DirectoryName);
        // Console.WriteLine(fileInfo.Exists);



        #endregion



        #region Path

        string extension = ".txt";
        string filename = "example";

        string fullFilename = filename + extension;


        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fullFilename);

        Console.WriteLine(path);

        #endregion
    }
}