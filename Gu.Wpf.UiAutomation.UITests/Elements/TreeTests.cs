﻿namespace Gu.Wpf.UiAutomation.UITests.Elements
{
    using Gu.Wpf.UiAutomation.UITests.TestFramework;
    using NUnit.Framework;

    public class TreeTests : UITestBase
    {
        private Tree tree;

        public TreeTests()
            : base(TestApplicationType.Wpf)
        {
        }

        [OneTimeSetUp]
        public void SelectTab()
        {
            var mainWindow = this.App.MainWindow();
            var tab = mainWindow.FindFirstDescendant(cf => cf.ByControlType(ControlType.Tab)).AsTab();
            tab.SelectTabItem(1);
            var tree = mainWindow.FindFirstDescendant(cf => cf.ByAutomationId("treeView1")).AsTree();
            this.tree = tree;
        }

        [Test]
        public void SelectionTest()
        {
            var tree = this.tree;
            Assert.That(tree.SelectedTreeItem, Is.Null);
            Assert.AreEqual(2, tree.TreeItems.Count);
            var treeItem = tree.TreeItems[0];
            treeItem.Expand();
            treeItem.TreeItems[1].Expand();
            treeItem.TreeItems[1].TreeItems[0].Select();
            Assert.That(tree.SelectedTreeItem, Is.Not.Null);
            Assert.That(tree.SelectedTreeItem.Text, Is.EqualTo("Lvl3 a"));
        }
    }
}
