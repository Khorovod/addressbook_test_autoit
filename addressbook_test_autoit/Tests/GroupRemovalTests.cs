using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace addressbook_test_autoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {

            GroupData newGroup = new GroupData()
            {
                Name = "Группа Подхвата"
            };

            if (!app.Groups.IsGroupPresent())
            {
                app.Groups.Add(newGroup);
            }
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.RemoveGroup();

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups , newGroups);
        }
    }
}
