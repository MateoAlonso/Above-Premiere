using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Above_Premiere.Model
{
    static class Shell
    {
        private static readonly System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
        private static readonly System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
        public static void convertVideo(string videoPath, int var, string outputPath)
        {
            startInfo.FileName = "cmd.exe";
            switch (var)
            {
                case 1:
                    startInfo.Arguments = "/C ffmpeg -i " + videoPath + " " + outputPath + ".mp4";
                    break;

                case 2:
                    startInfo.Arguments = "/C ffmpeg -i " + videoPath + " " + outputPath + ".avi";
                    break;

                case 3:
                    startInfo.Arguments = "/C ffmpeg -i " + videoPath + " " + outputPath + ".mpeg";
                    break;

                case 4:
                    startInfo.Arguments = "/C ffmpeg -i " + videoPath + " " + outputPath + ".flv";
                    break;

                default:
                    break;
            }
            
            pProcess.StartInfo = startInfo;
            pProcess.Start();
        }

        public static void extractAudio(string videoPath, string outputPath) 
        {
            //ffmpeg -i video.mp4 -f mp3 -ab 192000 -vn music.mp3
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ffmpeg -i " + videoPath + " -f mp3 -ab 192000 -vn " + outputPath + ".mp3";
            pProcess.StartInfo = startInfo;
            pProcess.Start();
        }

        public static void changeRes(string videoPath, int x, int y, string outputPath)
        {
            //ffmpeg - i input.avi - vf scale = 320:240 output.avi
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ffmpeg -i " + videoPath + " -vf scale = " + x + ":" + y + " " + outputPath;
            pProcess.StartInfo = startInfo;
            pProcess.Start();
        }
        public static void removeAudio(string videoPath, string outputPath)
        {
            //ffmpeg -i $input_file -c copy -an $output_file
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ffmpeg -i " + videoPath + " -c copy -an " + outputPath;
            pProcess.StartInfo = startInfo;
            pProcess.Start();
        }

        public static void extractImgXFrames(string videoPath, int frames, string outputPath)
        {
            //ffmpeg - i input.mov - vf "select=not(mod(n\,10))" - vsync vfr - q:v 2 img_ % 03d.jpg
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ffmpeg -i " + videoPath + " -vf 'select = not(mod(n/," + frames +"))' - vsync vfr - q:v 2 " + outputPath + " % 03d.jpg";
            pProcess.StartInfo = startInfo;
            pProcess.Start();
        }

    }


}
