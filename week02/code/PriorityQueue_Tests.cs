using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue multiple items and dequeue one
    // Expected Result: The item with the highest priority is dequeued
    // Defect(s) Found: In original implementation, Dequeue returned item by insertion order, not by highest priority.
    public void TestPriorityQueue_HighestPriorityIsDequeued()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Dequeue should remove the item with the highest priority even if added later
    // Expected Result: The item with the highest priority (even if added last) is dequeued
    // Defect(s) Found: Original implementation favored items enqueued earlier even with lower priority.

    public void TestPriorityQueue_RespectPriorityNotInsertionOrder()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 2);
        priorityQueue.Enqueue("Second", 3);
        priorityQueue.Enqueue("Last", 5); // Highest priority

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Last", result);
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected Result: InvalidOperationException is thrown
    // Defect(s) Found: Original implementation returned null instead of throwing InvalidOperationException.
    public void TestPriorityQueue_DequeueThrowsIfEmpty()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with same priority, check if any one is removed
    // Expected Result: One of them is removed and returned, not null
    // Defect(s) Found: Original implementation always returned the last added item, ignoring tie-breaking fairness.
    public void TestPriorityQueue_SamePriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 5);

        var result = priorityQueue.Dequeue();

        Assert.IsTrue(result == "A" || result == "B" || result == "C");
    }
}