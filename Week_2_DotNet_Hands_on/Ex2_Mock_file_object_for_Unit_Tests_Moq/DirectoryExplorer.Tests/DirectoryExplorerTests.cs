using NUnit.Framework;
using Moq;
using MagicFilesLib;
using System.Collections.Generic;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        private Mock<IDirectoryExplorer> _mockDirectoryExplorer;
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";

        [OneTimeSetUp]
        public void Init()
        {
            _mockDirectoryExplorer = new Mock<IDirectoryExplorer>();
            _mockDirectoryExplorer
                .Setup(x => x.GetFiles(It.IsAny<string>()))
                .Returns(new List<string> { _file1, _file2 });
        }

        [Test]
        public void GetFiles_ShouldReturnExpectedFileList()
        {
            var files = _mockDirectoryExplorer.Object.GetFiles("any/fake/path");

            Assert.IsNotNull(files);
            Assert.AreEqual(2, files.Count);
            Assert.Contains(_file1, new List<string>(files)); // ✅ FIXED: cast to List<string>
        }
    }
}

