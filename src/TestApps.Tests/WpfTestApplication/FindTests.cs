﻿namespace WpfTestApplication
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;

    #endregion

    [TestFixture]
    public class FindTests : BaseTest
    {
        #region Public Methods and Operators

        [Test]
        public void FindChildElementByClassNameTest()
        {
            var parent = this.Driver.FindElementById("WpfTestApplicationMainWindow");
            var child = parent.FindElement(By.ClassName("TextBox"));
            Assert.NotNull(child);
        }

        [Test]
        public void FindChildElementByIdTest()
        {
            var parent = this.Driver.FindElementById("WpfTestApplicationMainWindow");
            var child = parent.FindElement(By.Id("TextBox1"));
            Assert.NotNull(child);
        }

        [Test]
        public void FindChildElementByNameTest()
        {
            var parent = this.Driver.FindElementById("WpfTestApplicationMainWindow");
            var child = parent.FindElement(By.Name("IsEnabledTextListBox"));
            Assert.NotNull(child);
        }

        [Test]
        public void FindElementByClassNameTest()
        {
            var element = this.Driver.FindElement(By.ClassName("Window"));
            Assert.NotNull(element);
        }

        [Test]
        public void FindElementByIdTest()
        {
            var element = this.Driver.FindElement(By.Id("WpfTestApplicationMainWindow"));
            Assert.NotNull(element);
        }

        [Test]
        public void FindElementByNameTest()
        {
            var element = this.Driver.FindElement(By.Name("MainWindow"));
            Assert.NotNull(element);
        }

        [Test]
        public void FindElementsTest()
        {
            var parent = this.Driver.FindElementById("WpfTestApplicationMainWindow");
            var childElements = parent.FindElements(By.ClassName(string.Empty));
            Assert.AreEqual(10, childElements.Count);
        }

        #endregion
    }
}
