﻿namespace Gu.Wpf.UiAutomation.UITests.Elements
{
    using Gu.Wpf.UiAutomation.UITests.TestFramework;
    using NUnit.Framework;

    public class TabTests : UITestBase
    {
        public TabTests()
            : base(TestApplicationType.Wpf)
        {
        }

        [Test]
        public void TabSelectTest()
        {
            this.RestartApp();
            var mainWindow = this.App.MainWindow();
            var tab = mainWindow.FindFirstDescendant(cf => cf.ByControlType(ControlType.Tab)).AsTab();
            Assert.That(tab.TabItems, Has.Length.EqualTo(2));
            Assert.That(tab.SelectedTabItemIndex, Is.EqualTo(0));
            tab.SelectTabItem(1);
            Helpers.WaitUntilInputIsProcessed();
            Assert.That(tab.SelectedTabItemIndex, Is.EqualTo(1));
            tab.SelectTabItem(0);
            Helpers.WaitUntilInputIsProcessed();
            Assert.That(tab.SelectedTabItemIndex, Is.EqualTo(0));
        }
    }
}
