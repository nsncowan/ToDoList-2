using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList2.Models;
using System.Collections.Generic;

namespace ToDoList2.Tests
{
  [TestClass]
  public class ItemTests: IDisposable
  {
    
    public void Dispose()
    {
      Item.ClearAll();
    }
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      string result = newItem.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      string updatedDescription = "Do the dishes.";
      newItem.Description = updatedDescription;
      string result = newItem.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Item> newList = new List<Item> { };

      List<Item> result = Item.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      string description01 = "Walk the dog.";
      string description02 = "Wash the dishes.";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);
      List<Item> newList = new List<Item> {newItem1, newItem2};

      List<Item> result = Item.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}







// Example test format:

/*

[TestMethod]
public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
{
  // any necessary logic to prep for test; instantiating new classes, etc.
  Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
}

 */