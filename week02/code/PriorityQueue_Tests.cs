using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following items and priorities: Erick (2), Eduardo (5), Cesar (3) and
    // run until the queue is empty
    // Expected Result: Eduardo, Cesar, Erick
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var erick = new PriorityItem("Erick", 2);
        var eduardo = new PriorityItem("Eduardo", 5);
        var cesar = new PriorityItem("Cesar", 3);

        PriorityItem[] expectedResult = { eduardo, cesar, erick };

        var players = new PriorityQueue();
        players.Enqueue(erick.Value, erick.Priority);
        players.Enqueue(eduardo.Value, eduardo.Priority);
        players.Enqueue(cesar.Value, cesar.Priority);

        int i = 0;
        while (players.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have run out of items by now.");
            }

            var person = players.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, person);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the following items and priorities: Erick (15), Eduardo (5), Cesar (5)
    // Expected Result: Eduardo, Cesar, Erick
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var erick = new PriorityItem("Erick", 15);
        var eduardo = new PriorityItem("Eduardo", 5);
        var cesar = new PriorityItem("Cesar", 5);

        PriorityItem[] expectedResult = { erick, eduardo, cesar };

        var players = new PriorityQueue();
        players.Enqueue(erick.Value, erick.Priority);
        players.Enqueue(eduardo.Value, eduardo.Priority);
        players.Enqueue(cesar.Value, cesar.Priority);

        int i = 0;
        while (players.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have run out of items by now.");
            }

            var person = players.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, person);
            i++;
        }
    }

    // Add more test cases as needed below.
}
