using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

using AR.Drone.Data;
using AR.Drone.Data.Navigation;
using AR.Drone.Media;
using AR.Drone.Video;
using AR.Drone.Avionics;

using PixelFormat = System.Drawing.Imaging.PixelFormat;
using VideoPixelFormat = AR.Drone.Video.PixelFormat;
using System;
using AR.Drone.Client.Configuration;
using DroneProject2.Controller;

namespace DroneProject2.src.controller
{
    public static class DroneVideo_API
    {
        private const string ARDroneTrackFileExt = ".ardrone";
        private const string ARDroneTrackFilesFilter = "AR.Drone track files (*.ardrone)|*.ardrone";

        public static VideoPacketDecoderWorker VideoPacketDecoderWorker;
        private static VideoFrame _frame;
        public  static Bitmap FrameBitmap;
        private static uint _frameNumber;
        public static NavigationData NavigationData;
        private static NavigationPacket _navigationPacket;
        private static PacketRecorder _packetRecorderWorker;


        public static void HorizontalCamera()
        {
            var configuration = new Settings();
            configuration.Video.Channel = VideoChannelType.Horizontal;
            Program.DClient.Send(configuration);
        }

        public static void VerticalCamera()
        {
            var configuration = new Settings();
            configuration.Video.Channel = VideoChannelType.Vertical;
            Program.DClient.Send(configuration);
        }

        public static void VideoWorkerBinder()
        {
            //Let's do video Inputs
            VideoPacketDecoderWorker  = new VideoPacketDecoderWorker(AR.Drone.Video.PixelFormat.BGR24, true, OnVideoPacketDecoded);
            VideoPacketDecoderWorker.Start();

            HorizontalCamera();
        }

        public static void VideoTimerTick()
        {
            if (_frame == null || _frameNumber == _frame.Number)
                return;
            _frameNumber = _frame.Number;

            if (FrameBitmap == null)
                FrameBitmap = VideoHelper.CreateBitmap(ref _frame);
            else
                VideoHelper.UpdateBitmap(ref FrameBitmap, ref _frame);
        }

        public static void OnNavigationPacketAcquired(NavigationPacket packet)
        {
            //check if the worker is valid then send the nav packet to the worker. 
            if (_packetRecorderWorker != null && _packetRecorderWorker.IsAlive)
                _packetRecorderWorker.EnqueuePacket(packet);

            _navigationPacket = packet;
        }

        public static void OnVideoPacketAcquired(VideoPacket packet)
        {
            //check if the worker is valid then send the nav packet to the worker. 
            if (_packetRecorderWorker != null && _packetRecorderWorker.IsAlive)
                _packetRecorderWorker.EnqueuePacket(packet);
            if (VideoPacketDecoderWorker.IsAlive)
                VideoPacketDecoderWorker.EnqueuePacket(packet);
        }

        public static void OnVideoPacketDecoded(VideoFrame frame)
        {
            _frame = frame;
        }
    }

    public static class VideoHelper
    {
        public static PixelFormat ConvertPixelFormat(VideoPixelFormat pixelFormat)
        {
            switch (pixelFormat)
            {
                case VideoPixelFormat.Gray8:
                    return PixelFormat.Format8bppIndexed;
                case VideoPixelFormat.BGR24:
                    return PixelFormat.Format24bppRgb;
                case VideoPixelFormat.RGB24:
                    throw new NotSupportedException();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static Bitmap CreateBitmap(ref VideoFrame frame)
        {
            PixelFormat pixelFormat = ConvertPixelFormat(frame.PixelFormat);
            var bitmap = new Bitmap(frame.Width, frame.Height, pixelFormat);
            if (pixelFormat == PixelFormat.Format8bppIndexed)
            {
                ColorPalette palette = bitmap.Palette;
                for (int i = 0; i < palette.Entries.Length; i++)
                {
                    palette.Entries[i] = Color.FromArgb(i, i, i);
                }
                bitmap.Palette = palette;
            }
            UpdateBitmap(ref bitmap, ref frame);
            return bitmap;
        }

        public static void UpdateBitmap(ref Bitmap bitmap, ref VideoFrame frame)
        {
            var rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData data = bitmap.LockBits(rect, ImageLockMode.WriteOnly, bitmap.PixelFormat);
            Marshal.Copy(frame.Data, 0, data.Scan0, frame.Data.Length);
            bitmap.UnlockBits(data);
        }
    }
}
