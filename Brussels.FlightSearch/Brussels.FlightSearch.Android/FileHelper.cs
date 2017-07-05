using System;
using Brussels.FlightSearch.Abstract;
using System.IO;
using Xamarin.Forms;
using Brussels.FlightSearch.Droid;
using Android.Content.Res;

[assembly: Dependency(typeof(FileHelper))]
namespace Brussels.FlightSearch.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }

        public bool IsFileExist(string filename)
        {
            return File.Exists(filename);
        }

        public string ReadFile(string filename)
        {
            string fileContent = string.Empty;

            AssetManager assets = Android.App.Application.Context.Assets;

            using (var stream = assets.Open(filename))
            {
                if (stream != null && stream.CanRead)
                {
                    using (var streamReader = new StreamReader(stream))
                    {
                        fileContent = streamReader.ReadToEnd();
                    }
                }
            }          

            return fileContent;
        }
    }
}