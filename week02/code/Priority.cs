public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Test if Enqueue() actually adds an item to the queue. Add an item to the queue and assert the size of the queue.
        // Expected Result: True
        Console.WriteLine("Test 1");
        var queue = new PriorityQueue();
        queue.Enqueue("Item 1", 1);
        Console.WriteLine(queue.ToString());
        while (true)
        {
            if (queue.ToString() == "[Item 1 (Pri:1)]")
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            break;
        }

        // Defect(s) Found: No Defect yet

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Test if Dequeue() removes the highest priority item from the queue. Add items with different priorities and assert the value of the dequeued item.
        // Expected Result: True
        Console.WriteLine("Test 2");
        var queue2 = new PriorityQueue();
        queue2.Enqueue("item1", 1);
        queue2.Enqueue("item2", 2);

        // Dequeue highest priority item
        string dequeuedValue = queue2.Dequeue();

        // The highest priority item should be "item2"
        if (dequeuedValue == "item2")
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

        // Defect(s) Found: Dequeue doesn't happen correctly

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        // Test 3
        // Scenario: Test if Dequeue() removes the oldest highest priority item from the queue. Add items with the same priorities and assert the value of the dequeued item.
        // Expected Result: True
        Console.WriteLine("Test 3");
        var queue3 = new PriorityQueue();
        queue3.Enqueue("item1", 1);
        queue3.Enqueue("item2", 1);

        while (true)
        {
            if (queue3.ToString() == "[item1 (Pri:1), item2 (Pri:1)]")
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            break;
        }

        // Defect(s) Found: No Defect

        Console.WriteLine("---------");
        
        // Test 4
        // Scenario: Test if Dequeue() on empty queue returns null and doesn't throw any exception.
        // Expected Result: must not throw exception and return null/ True
        Console.WriteLine("Test 4");
        var queue4 = new PriorityQueue();
        try
        {
            string result = queue4.Dequeue();
            if (result == null)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception {ex.GetType()} was thrown with message '{ex.Message}'");
        }
        // Defect(s) Found: No Defect

        Console.WriteLine("---------");
    }
}
