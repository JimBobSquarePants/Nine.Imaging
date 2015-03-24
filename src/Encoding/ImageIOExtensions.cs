﻿namespace Nine.Imaging
{
    using System.IO;
    using System.ComponentModel;
    using Nine.Imaging.Encoding;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ImageIOExtensions
    {
        public static void SaveAsPng(this Image image, Stream stream) => new PngEncoder().Encode(image, stream);
        public static void SaveAsJpeg(this Image image, Stream stream) => new JpegEncoder().Encode(image, stream);
        public static void Save(this Image image, Stream stream, IImageEncoder encoder) => encoder.Encode(image, stream);
    }
}