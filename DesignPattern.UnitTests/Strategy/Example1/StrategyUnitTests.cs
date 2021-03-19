using DesignPattern.StrategyPattern.Exercise1;
using NUnit.Framework;

namespace DesignPattern.UnitTests.Strategy.Example1
{
    public class StrategyUnitTests
    {
        private const string JpegCompressResult = "Compressing using Jpeg";
        private const string PngCompressResult = "Compressing using Png";
        private const string FilterResult = "Applying black and white filter";
        private ImageStorage imageStorage;

        [SetUp]
        public void SetUp()
        {
            imageStorage = new ImageStorage();
        }

        [Test]
        public void JPEGCompressor_WhenCalled_CompressUsingJPEG()
        {
            imageStorage.Store("a", new JpegCompressor(), new BlackAndWhiteFilter());
            Assert.That(imageStorage.CompressResult, Is.EqualTo(JpegCompressResult));
            Assert.That(imageStorage.FilterResult, Is.EqualTo(FilterResult));
        }

        [Test]
        public void PNGCompressor_WhenCalled_CompressUsingPNG()
        {
            imageStorage.Store("a", new PngCompressor(), new BlackAndWhiteFilter());
            Assert.That(imageStorage.CompressResult, Is.EqualTo(PngCompressResult));
            Assert.That(imageStorage.FilterResult, Is.EqualTo(FilterResult));
        }
    }
}