using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nuget - MencoderSharp

namespace VideoCompressor
{
    class Program
    {
        static void Main(string[] args)
        {

            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();

            ffMpeg.ConvertMedia("example.mpg", "video.mp4", "mp4");

        }
    }
}
