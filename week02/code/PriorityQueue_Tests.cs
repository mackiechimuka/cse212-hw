using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adding items to the priority queue with different priorites and then removing them to ensure the one with the highest priority comes out first
    // Tinashe (2),Nyasha(6),Tawanda(1),Tendai(5)
    // Expected Result: item with highest priority is removesd first: Nyasha(6), Tendai(5), Tinashe(2), Tawanda(1)
    // Defect(s) Found: It failed to remove the item with the highest priority first. It removed Tawanda(1) first instead of Nyasha(6)
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Tinashe",2);
        priorityQueue.Enqueue("Nyasha",6);
        priorityQueue.Enqueue("Tawanda",1);
        priorityQueue.Enqueue("Tendai",5);
        Assert.AreEqual("Nyasha", priorityQueue.Dequeue());
        Assert.AreEqual("Tendai", priorityQueue.Dequeue());
        Assert.AreEqual("Tinashe", priorityQueue.Dequeue());
        Assert.AreEqual("Tawanda", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add 2 items to the priority queue with the same priority and mix it with other items of different prioties.
    // Madrid (3), Barcelona(5), Valencia(5), Sevilla(2)
    // Expected Result: Barcelona(5) and Valencia(5) should be removed first in the order they were added, followed by Madrid(3) and Sevilla(2)
    // Defect(s) Found: It failed to remove the items with the same priority in the order they were added. It removed Valencia(5) first instead of Barcelona(5)
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Madrid", 3);
        priorityQueue.Enqueue("Barcelona", 5);
        priorityQueue.Enqueue("Valencia", 5);
        priorityQueue.Enqueue("Sevilla", 2);
        Assert.AreEqual("Barcelona", priorityQueue.Dequeue());
        Assert.AreEqual("Valencia", priorityQueue.Dequeue());
        Assert.AreEqual("Madrid", priorityQueue.Dequeue());
        Assert.AreEqual("Sevilla", priorityQueue.Dequeue());
    }


    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Add three items of the same priority to the queue and remove them to ensure they are removed in the order they were added.
    // Arsenal (4), Chelsea(4), Liverpool(4)
    // Expected Result: Arsenal(4), Chelsea(4), Liverpool(4)
    // Defect(s) Found: It failed to remove the items with the same priority in the order they were added. It removed Chelsea(4) first instead of Arsenal(4)
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Arsenal", 4);
        priorityQueue.Enqueue("Chelsea", 4);
        priorityQueue.Enqueue("Liverpool", 4);
        Assert.AreEqual("Arsenal", priorityQueue.Dequeue());
        Assert.AreEqual("Chelsea", priorityQueue.Dequeue());
        Assert.AreEqual("Liverpool", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to remove an item from an empty priority queue.
    // Expected Result: ApplicationException is thrown.
    // Defect(s) Found: It passed the test case and did not throw an exception when trying to remove an item from an empty queue.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected InvalidOperationException was not thrown.");
        }
        catch (InvalidOperationException e)
        {
            // Expected exception was thrown, test passes.
            Assert.AreEqual("The queue is empty.", e.Message);

        }
    }
}