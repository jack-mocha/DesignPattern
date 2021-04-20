using DesignPattern.ChainOfResponsibilityPattern.Example1;
using NUnit.Framework;

namespace DesignPattern.UnitTests
{
    public class ServerUnitTests
    {
        private Logger logger;
        private Compressor compressor;
        private Authenticator authenticator;
        private string username;
        private string password;
        private string authResultIsTrue = "IsAuthenticated: True";
        private string authResultIsFalse = "IsAuthenticated: False";
        private string compressorResultIsTrue = "IsCompressed: True";
        private string loggerResultIsTrue = "IsLogged: True";

        [SetUp]
        public void Setup()
        {
            username = "admin";
            password = "1234";
        }

        [Test]
        public void ThreeHandler_WhenCalled_AllReturnTrue()
        {
            logger = new Logger(null);
            compressor = new Compressor(logger);
            authenticator = new Authenticator(compressor);
            var server = new WebServer(authenticator);
            
            server.Handle(new HttpRequest(username, password));

            Assert.That(authenticator.Result, Is.EqualTo(authResultIsTrue));
            Assert.That(compressor.Result, Is.EqualTo(compressorResultIsTrue));
            Assert.That(logger.Result, Is.EqualTo(loggerResultIsTrue));
        }


        [Test]
        public void TwoHandler_WhenCalled_AllReturnTrue()
        {
            logger = new Logger(null);
            authenticator = new Authenticator(logger);
            var server = new WebServer(authenticator);

            server.Handle(new HttpRequest(username, password));

            Assert.That(authenticator.Result, Is.EqualTo(authResultIsTrue));
            Assert.That(logger.Result, Is.EqualTo(loggerResultIsTrue));
        }

        [Test]
        public void Auth_WhenAuthFails_AuthReturnFalseAndNoActionFromOtherHandlers()
        {
            logger = new Logger(null);
            compressor = new Compressor(logger);
            authenticator = new Authenticator(compressor);
            var server = new WebServer(authenticator);

            server.Handle(new HttpRequest("incorrectUsername", password));

            Assert.That(authenticator.Result, Is.EqualTo(authResultIsFalse));
        }
    }
}